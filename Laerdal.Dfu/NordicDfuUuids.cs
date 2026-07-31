using System;

namespace Laerdal.Dfu
{
    /// <summary>
    /// GUIDs for Nordic's Legacy and Secure DFU GATT services and characteristics, ported from
    /// scl-ble's <c>LegacyDfuServiceDefinition</c> / <c>SecureDfuServiceDefinition</c>. Pure protocol
    /// constants with zero BLE-stack dependencies - consumers use them together with whatever
    /// characteristic-presence/read API their BLE stack exposes.
    /// </summary>
    public static class NordicDfuUuids
    {
        /// <summary>Legacy DFU Service (pre-SDK 12 bootloaders).</summary>
        public static readonly Guid LegacyDfuService = new("00001530-1212-EFDE-1523-785FEABCD123");

        /// <summary>Legacy DFU Control Point characteristic.</summary>
        public static readonly Guid LegacyDfuControlPoint = new("00001531-1212-EFDE-1523-785FEABCD123");

        /// <summary>
        /// Legacy DFU Packet characteristic. Absent while the device is running the application
        /// (not the bootloader) - its presence is one of the signals used to detect DFU mode.
        /// </summary>
        public static readonly Guid LegacyDfuPacket = new("00001532-1212-EFDE-1523-785FEABCD123");

        /// <summary>Legacy DFU Status Report characteristic.</summary>
        public static readonly Guid LegacyDfuStatusReport = new("00001533-1212-EFDE-1523-785FEABCD123");

        /// <summary>
        /// Legacy DFU Version characteristic. In application mode with buttonless update enabled,
        /// always reads back as major=0, minor=1 - any other value implies the device is in DFU mode.
        /// </summary>
        public static readonly Guid LegacyDfuVersion = new("00001534-1212-EFDE-1523-785FEABCD123");

        /// <summary>Secure DFU Service (SDK 12+ bootloaders).</summary>
        public static readonly Guid SecureDfuService = new("0000FE59-0000-1000-8000-00805F9B34FB");

        /// <summary>
        /// Secure DFU Control Point characteristic. Absent while the device is running the
        /// application (not the bootloader) - its presence is one of the signals used to detect DFU mode.
        /// </summary>
        public static readonly Guid SecureDfuControlPoint = new("8EC90001-F315-4F60-9FB8-838830DAEA50");

        /// <summary>Secure DFU Packet characteristic.</summary>
        public static readonly Guid SecureDfuPacket = new("8EC90002-F315-4F60-9FB8-838830DAEA50");

        /// <summary>Buttonless DFU (without bonds) characteristic.</summary>
        public static readonly Guid ButtonlessDfuWithoutBonds = new("8EC90003-F315-4F60-9FB8-838830DAEA50");

        /// <summary>Buttonless DFU (with bonds) characteristic.</summary>
        public static readonly Guid ButtonlessDfuWithBonds = new("8EC90004-F315-4F60-9FB8-838830DAEA50");
    }
}
