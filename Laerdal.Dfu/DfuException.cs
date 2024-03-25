using System;
using Laerdal.Dfu.Enums;

namespace Laerdal.Dfu
{
    public class DfuException : Exception
    {
        public DfuException(DfuError error, string message) : base($"{error} ({(long)error}) : {message}") { }
        
    }
}