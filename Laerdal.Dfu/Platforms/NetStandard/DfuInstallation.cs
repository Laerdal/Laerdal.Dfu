namespace Laerdal.Dfu
{
    public partial class DfuInstallation
    {
        public DfuInstallation(string deviceId, string fileUrl) : base(deviceId, fileUrl)
        {
        }
        
        public override void Start(DfuConfiguration configuration = null)
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