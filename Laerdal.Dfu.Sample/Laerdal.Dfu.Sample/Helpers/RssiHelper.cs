namespace Laerdal.Dfu.Sample.Helpers
{
    /// <summary>
    ///     Rssi calculation functions.
    /// </summary>
    public static class RssiHelper
    {
        // Max and Min are dynamic, meaning if a value higher or lower is detected it will push the bounds
        private static double _closeRssiValue = -50;

        private static double _farRssiValue = -100;

        /// <summary>
        ///     Turns a DBM RSSI value into a percentage, compared to the highest RSSI recorded and tha lowest.
        /// </summary>
        /// <param name="rssi">Input in DBM.</param>
        /// <returns>Percentage.</returns>
        public static double RssiToSignalStrengthConverter(double rssi)
        {
            if (rssi <= _farRssiValue)
            {
                _farRssiValue = rssi;
                return 0;
            }

            if (rssi >= _closeRssiValue)
            {
                _closeRssiValue = rssi;
                return 1;
            }

            // Distance = ( rssi - Far ) / ( Close - Far)

            // Example :
            // Rssi : -64
            // ( -64 - ( -100 )) / (( -26 ) - ( -100 ))
            // (-64+100) / (-26+100)
            // 36/74
            // 0.49
            return (rssi - _farRssiValue) / (_closeRssiValue - _farRssiValue);
        }
    }
}