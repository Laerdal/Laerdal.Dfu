namespace Laerdal.Dfu.Enums
{
    public enum DfuState : long
    {
        Connecting = 0,

        Starting = 1,

        EnablingDfuMode = 2,

        Uploading = 3,

        Validating = 4,

        Disconnecting = 5,

        Completed = 6,

        Aborted = 7,

        // DO NOT CHANGE ORDER ABOVE

        Error,

        // For android
        Started,

        Connected,

        Disconnected,
    }
}