namespace Laerdal.Xamarin.Dfu.Specific
{
    public class DfuServiceDelegate : Laerdal.Xamarin.Dfu.iOS.DFUServiceDelegate
    {
        private DfuInstallation DfuInstallation { get; }

        public DfuServiceDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation; 
        }

        public override void DfuError(Laerdal.Xamarin.Dfu.iOS.DFUError error, string message)
        {
            DfuInstallation?.OnDfuError((Laerdal.Xamarin.Dfu.Enums.DfuError) (long) error, message);
        }

        public override void DfuStateDidChangeTo(Laerdal.Xamarin.Dfu.iOS.DFUState state)
        {
            DfuInstallation.State = (Laerdal.Xamarin.Dfu.Enums.DfuState) (long) state;
        }
    }
}