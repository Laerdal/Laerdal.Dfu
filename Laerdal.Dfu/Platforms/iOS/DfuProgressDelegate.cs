using Foundation;

using Laerdal.Dfu.Bindings.iOS;
using Laerdal.Dfu.Enums;

using System;

namespace Laerdal.Dfu
{
    public class DfuProgressDelegate : NSObject, IDFUProgressDelegate, IDFUServiceDelegate
    {
        private DfuInstallation DfuInstallation { get; }

        public DfuProgressDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation;
        }
        
// https://github.com/xamarin/xamarin-macios/issues/13087
#if XAMARINIOS
        public void OutOf(System.nint part,
            System.nint totalParts,
            System.nint progress,
            double currentSpeedBytesPerSecond,
            double avgSpeedBytesPerSecond)
#else
        public void OutOf(nint part,
            nint totalParts,
            nint progress,
            double currentSpeedBytesPerSecond,
            double avgSpeedBytesPerSecond)
#endif
        {
            DfuInstallation.OnDfuStateChanged(DfuState.Uploading);
            DfuInstallation.OnProgressChanged((int) progress / 100D, currentSpeedBytesPerSecond, avgSpeedBytesPerSecond);
        }
        
        public void DfuStateDidChangeTo(DFUState state)
        {
            DfuInstallation.OnDfuStateChanged((Laerdal.Dfu.Enums.DfuState) (long) state);
        }
        
        public void DfuError(DFUError error, string message)
        {
            DfuInstallation.OnDfuErrorReceived((Laerdal.Dfu.Enums.DfuError) (long) error, message);
            DfuInstallation.OnDfuStateChanged(DfuState.Error);
        }
    }
}