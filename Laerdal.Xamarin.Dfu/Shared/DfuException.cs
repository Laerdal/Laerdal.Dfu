using System;
using Laerdal.Xamarin.Dfu.Enums;

namespace Laerdal.Xamarin.Dfu
{
    public class DfuException : Exception
    {
        public DfuException(DfuError error, string message) : base($"{error} ({(long)error}) : {message}") { }
        
    }
}