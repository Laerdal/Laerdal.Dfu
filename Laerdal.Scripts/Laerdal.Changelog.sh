#!/bin/bash

usage(){
    echo "usage: ./Laerdal.Changelog.sh [-nv | --new-version X.Y.Z] [-o | --output version.txt] [-h | --help]"
    echo "parameters:"
    echo "  -nv | --new-version [version]       New major.minor.patch version (default is 0.0.0)"
    echo "  -o | --output [filename]           Name of the output file"
    echo "  -h | --help                        Prints this message"
    echo "  -v | --verbose                     Verbose mode"
}

function log () {
    if [[ $verbose -eq 1 ]]; then
        echo "$@"
    fi
}

filename="CHANGELOG.md"

while [ "$1" != "" ]; do
    case $1 in
        -nv | --new-version )       shift
                                    newversion="$1"
                                    ;;
        -o | --output )             shift
                                    filename="$1"
                                    ;;
        -h | --help )               usage
                                    exit
                                    ;;
        -v | --verbose )            verbose=1
                                    ;;
        * )                         echo
                                    echo "### Wrong parameter: $1 ###"
                                    echo
                                    usage
                                    exit 1
    esac
    shift
done


if [ ! -z "$newversion" ]; then
    if [[ "$newversion" =~ .*"-".* ]]; then
        log "New version contains a dash, skipping changelog generation"
    else
        currenthash=$(git show --format=%h --no-patch)
        echo "$currenthash $newversion" > tags.txt
        log "New version: $newversion"
    fi
else 
    echo "" > tags.txt
fi

# Get all tags on develop and Filter out tags that are not in the format "HASH 1.2.3"
git tag --format='%(objectname:short) %(refname:short)' --sort=-version:refname --merged | grep -o '[a-z0-9]* [a-z0-9]*[.][a-z0-9]*[.][a-z0-9]*$' >> tags.txt

# Create changelog file
echo "# CHANGELOG" > "$filename"
echo "" >> "$filename"
log "Created changelog file: $filename"


# Loop through all tags and create changelog
lastline=''
while read line; do
    if [ -z "$lastline" ]; then
        lastline=$line
    else
        # Split the line into hash and version
        lasthash=`echo $lastline | cut -d' ' -f1`
        lastversion=`echo $lastline | cut -d' ' -f2`
        hash=`echo $line | cut -d' ' -f1`

        echo "## **$lastversion**" >> "$filename"
        log "Added version: $lastversion"
        # Get the commit message and author of the tag
        git log -n 1 --pretty=tformat:"%b" $lasthash >> "$filename"

        echo "" >> "$filename"

        # Get all commits between the current tag and the previous tag
        git log $hash..$lasthash --pretty=format:"- %s [%cn]" --no-merges >> "$filename"
        
        echo "" >> "$filename"
        echo "" >> "$filename"

        # Get the commit message and author of the tag
        git log -n 1 --pretty=tformat:"> by _%cn_ on _%cd_" --date=format:'%Y-%m-%d %H:%M:%S' $lasthash >> "$filename"

        echo "" >> "$filename"
        echo "---" >> "$filename"
        echo "" >> "$filename"
        lastline=$line
    fi
done < tags.txt

rm -r -f tags.txt

log "Done"

exit 0