using System;

namespace Laerdal.Dfu.Specific
{
    public class DfuProgressDelegate : Laerdal.Dfu.iOS.DFUProgressDelegate
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
            if (DfuInstallation != null)
            {
                DfuInstallation.Progress = (int) progress / 100D;
                DfuInstallation.CurrentSpeedBytesPerSecond = currentSpeedBytesPerSecond;
                DfuInstallation.AvgSpeedBytesPerSecond = avgSpeedBytesPerSecond;
            }
        }
    }
}