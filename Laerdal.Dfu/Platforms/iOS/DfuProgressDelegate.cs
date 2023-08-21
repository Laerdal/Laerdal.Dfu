using Laerdal.Dfu.Bindings.iOS;

namespace Laerdal.Dfu
{
    public class DfuProgressDelegate : DFUProgressDelegate
    {
        private DfuInstallation DfuInstallation { get; }

        public DfuProgressDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation;
        }
// https://github.com/xamarin/xamarin-macios/issues/13087
#if XAMARINIOS
        public override void OutOf(System.nint part,
            System.nint totalParts,
            System.nint progress,
            double currentSpeedBytesPerSecond,
            double avgSpeedBytesPerSecond)
        {
            DfuInstallation?.OnProgressChanged((int) progress / 100D, currentSpeedBytesPerSecond, avgSpeedBytesPerSecond);
        }
#else
        public override void OutOf(nint part,
            nint totalParts,
            nint progress,
            double currentSpeedBytesPerSecond,
            double avgSpeedBytesPerSecond)
        {
            DfuInstallation?.OnProgressChanged((int) progress / 100D, currentSpeedBytesPerSecond, avgSpeedBytesPerSecond);
        }
#endif
    }
}