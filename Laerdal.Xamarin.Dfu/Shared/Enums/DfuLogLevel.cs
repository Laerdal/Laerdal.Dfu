namespace Laerdal.Xamarin.Dfu.Enums
{
    public enum DfuLogLevel : long
    {
        Debug = 0,

        Verbose = 1,

        Info = 5,

        Application = 10, // 0x000000000000000A

        Warning = 15, // 0x000000000000000F

        Error = 20 // 0x0000000000000014
    }
}