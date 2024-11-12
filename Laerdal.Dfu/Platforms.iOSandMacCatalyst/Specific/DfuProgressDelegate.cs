using System;

namespace Laerdal.Dfu.Specific
{
    public class DfuProgressDelegate : Laerdal.Dfu.Bindings.iOS.DFUProgressDelegate
    {
        private DfuInstallation DfuInstallation { get; }

        public DfuProgressDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation;
        }

        public override void OutOf(nint part,
                                   nint totalParts,
                                   nint progress,
                                   double currentSpeedBytesPerSecond,
                                   double avgSpeedBytesPerSecond)
        {
            DfuInstallation?.OnProgressChanged((int) progress / 100D, currentSpeedBytesPerSecond, avgSpeedBytesPerSecond);
        }
    }
}