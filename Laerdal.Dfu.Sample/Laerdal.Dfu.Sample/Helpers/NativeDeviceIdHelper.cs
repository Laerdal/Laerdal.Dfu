using System;

namespace Laerdal.Dfu.Sample.Helpers
{
    public static class NativeDeviceIdHelper
    {
        public static Func<object, string> GetIdFromNativeDevice { get; set; }
    }
}