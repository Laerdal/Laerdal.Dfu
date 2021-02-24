namespace Laerdal.Xamarin.Dfu.Enums
{
    public enum DfuError : long
    {
        NoError = 0,

        RemoteLegacyDfuSuccess = 1,

        RemoteLegacyDfuInvalidState = 2,

        RemoteLegacyDfuNotSupported = 3,

        RemoteLegacyDfuDataExceedsLimit = 4,

        RemoteLegacyDfuCrcError = 5,

        RemoteLegacyDfuOperationFailed = 6,

        RemoteSecureDfuSuccess = 11, // 0x000000000000000B

        RemoteSecureDfuOpCodeNotSupported = 12, // 0x000000000000000C

        RemoteSecureDfuInvalidParameter = 13, // 0x000000000000000D

        RemoteSecureDfuInsufficientResources = 14, // 0x000000000000000E

        RemoteSecureDfuInvalidObject = 15, // 0x000000000000000F

        RemoteSecureDfuSignatureMismatch = 16, // 0x0000000000000010

        RemoteSecureDfuUnsupportedType = 17, // 0x0000000000000011

        RemoteSecureDfuOperationNotPermitted = 18, // 0x0000000000000012

        RemoteSecureDfuOperationFailed = 20, // 0x0000000000000014

        RemoteSecureDfuExtendedError = 21, // 0x0000000000000015

        RemoteExtendedErrorWrongCommandFormat = 22, // 0x0000000000000016

        RemoteExtendedErrorUnknownCommand = 23, // 0x0000000000000017

        RemoteExtendedErrorInitCommandInvalid = 24, // 0x0000000000000018

        RemoteExtendedErrorFwVersionFailure = 25, // 0x0000000000000019

        RemoteExtendedErrorHwVersionFailure = 26, // 0x000000000000001A

        RemoteExtendedErrorSdVersionFailure = 27, // 0x000000000000001B

        RemoteExtendedErrorSignatureMissing = 28, // 0x000000000000001C

        RemoteExtendedErrorWrongHashType = 29, // 0x000000000000001D

        RemoteExtendedErrorHashFailed = 30, // 0x000000000000001E

        RemoteExtendedErrorWrongSignatureType = 31, // 0x000000000000001F

        RemoteExtendedErrorVerificationFailed = 32, // 0x0000000000000020

        RemoteExtendedErrorInsufficientSpace = 33, // 0x0000000000000021

        RemoteButtonlessDfuSuccess = 91, // 0x000000000000005B

        RemoteButtonlessDfuOpCodeNotSupported = 92, // 0x000000000000005C

        RemoteButtonlessDfuOperationFailed = 94, // 0x000000000000005E

        FileNotSpecified = 101, // 0x0000000000000065

        FileInvalid = 102, // 0x0000000000000066

        ExtendedInitPacketRequired = 103, // 0x0000000000000067

        InitPacketRequired = 104, // 0x0000000000000068

        FailedToConnect = 201, // 0x00000000000000C9

        DeviceDisconnected = 202, // 0x00000000000000CA

        BluetoothDisabled = 203, // 0x00000000000000CB

        ServiceDiscoveryFailed = 301, // 0x000000000000012D

        DeviceNotSupported = 302, // 0x000000000000012E

        ReadingVersionFailed = 303, // 0x000000000000012F

        EnablingControlPointFailed = 304, // 0x0000000000000130

        WritingCharacteristicFailed = 305, // 0x0000000000000131

        ReceivingNotificationFailed = 306, // 0x0000000000000132

        UnsupportedResponse = 307, // 0x0000000000000133

        BytesLost = 308, // 0x0000000000000134

        CrcError = 309, // 0x0000000000000135

        RemoteExperimentalButtonlessDfuSuccess = 9001, // 0x0000000000002329

        RemoteExperimentalButtonlessDfuOpCodeNotSupported = 9002, // 0x000000000000232A

        RemoteExperimentalButtonlessDfuOperationFailed = 9004, // 0x000000000000232C

        UnknownError
    }
}