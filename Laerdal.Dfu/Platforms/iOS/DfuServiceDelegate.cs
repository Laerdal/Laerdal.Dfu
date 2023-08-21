using Laerdal.Dfu.Bindings.iOS;

namespace Laerdal.Dfu
{
    public class DfuServiceDelegate : DFUServiceDelegate
    {
        private DfuInstallation DfuInstallation { get; }

        public DfuServiceDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation; 
        }

        public override void DfuError(DFUError error, string message)
        {
            DfuInstallation?.OnDfuError((Laerdal.Dfu.Enums.DfuError) (long) error, message);
        }

        public override void DfuStateDidChangeTo(DFUState state)
        {
            DfuInstallation.OnDfuStateChanged((Laerdal.Dfu.Enums.DfuState) (long) state);
        }
    }
}