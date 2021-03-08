using System;

namespace Laerdal.Dfu
{
    public partial class DfuInstallation
    {

        public DfuInstallation(string deviceId, string fileUrl) : base(deviceId, fileUrl)
        {
            throw new NotImplementedException();
            
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void Pause()
        {
            throw new NotImplementedException();
        }
        
        public override void Resume()
        {
            throw new NotImplementedException();
        }

        public override void Abort()
        {
            throw new NotImplementedException();
        }

    }
}