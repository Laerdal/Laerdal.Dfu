using System;
using System.Globalization;
using System.Linq;

namespace Laerdal.Dfu
{
    public partial class DfuInstallation
    {
        public DfuInstallation(string deviceId, string fileUrl) : base(deviceId, fileUrl)
        {
        }

        public DfuInstallation() : base()
        {
        }
        
        public override void Start()
        {
        }

        public override void Pause()
        {
        }

        public override void Resume()
        {
        }

        public override void Abort()
        {
        }

        protected override void Dispose(bool disposing)
        {
        }
    }
}