namespace KeyboardStatus
{
    internal class BatteryStatus
    {

        public BatteryStatus() { }

        public float LevelBaterry()
        {
            PowerStatus powerStatus = SystemInformation.PowerStatus;
            return powerStatus.BatteryLifePercent * 100;
        }

        public bool ChargingStatus()
        {
            PowerStatus powerStatus = SystemInformation.PowerStatus;
            BatteryChargeStatus batteryStatus = powerStatus.BatteryChargeStatus;

            if (powerStatus.PowerLineStatus == PowerLineStatus.Online)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
    }
}
