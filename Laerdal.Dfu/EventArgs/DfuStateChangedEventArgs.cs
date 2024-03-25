using Laerdal.Dfu.Enums;

namespace Laerdal.Dfu.EventArgs
{
    public class DfuStateChangedEventArgs : System.EventArgs
    {
        public DfuState OldState { get; }
        public DfuState NewState { get; }

        internal DfuStateChangedEventArgs(DfuState oldState, DfuState newState)
        {
            OldState = oldState;
            NewState = newState;
        }
    }
}
