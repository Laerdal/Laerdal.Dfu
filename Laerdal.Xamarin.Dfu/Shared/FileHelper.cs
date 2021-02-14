using System;

namespace Laerdal.Xamarin.Dfu
{
    public static class FileHelper
    {
        
#if MONOANDROID
        internal static string AppDataDirectory => Android.App.Application.Context.FilesDir?.AbsolutePath ?? "/";
#endif
#if XAMARIN_IOS
        internal static string AppDataDirectory
        {
            get
            {
                // From : https:// github.com/xamarin/Essentials/blob/master/Xamarin.Essentials/FileSystem/FileSystem.ios.tvos.watchos.cs
                var dirs = Foundation.NSSearchPath.GetDirectories(Foundation.NSSearchPathDirectory.LibraryDirectory, Foundation.NSSearchPathDomain.User);
                if (dirs == null || dirs.Length == 0)
                {
                    // this should never happen...
                    return null;
                }

                return dirs[0];
            }
        }
#endif
#if NETSTANDARD
        internal static string AppDataDirectory => throw new NotImplementedException();
#endif

    }
}