namespace Laerdal.Dfu.Specific
{
    public class DfuServiceDelegate : Laerdal.Dfu.Bindings.iOS.DFUServiceDelegate
    {
        private DfuInstallation DfuInstallation { get; }

        public DfuServiceDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation; 
        }

        public override void DfuError(Laerdal.Dfu.Bindings.iOS.DFUError error, string message)
        {
            DfuInstallation?.OnDfuError((Laerdal.Dfu.Enums.DfuError) (long) error, message);
        }

        public override void DfuStateDidChangeTo(Laerdal.Dfu.Bindings.iOS.DFUState state)
        {
            DfuInstallation.State = (Laerdal.Dfu.Enums.DfuState) (long) state;
        }
    }
}