using System;
using static MegaTecBattDriverRestart.DisableDevice;
using static MegaTecBattDriverRestart.DisableDevice2;

namespace MegaTecBattDriverRestart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }

        static void Start()
        {
           //EnableMouse(true);
           //EnableMouse(false);
           EnableMegatecUPSBattery(false);
        }

        public static void EnableMegatecUPSBattery(bool enable)
        {
            // every type of device has a hard-coded GUID, this is the one for MegaTEC battery UPS
            Guid classGuid = new Guid("{745a17a0-74d3-11d0-b6fe-00a0c90f57da}");

            // get this from the properties dialog box of this device in Device Manager
            string instanceId = @"HID\VID_0001&PID_0000\6&7EFA158&0&0000";

            //DeviceHelper2.ToggleDeviceEnabled(classGuid, instanceId);
            DeviceHelper.SetDeviceEnabled(classGuid, instanceId, enable);
        }

        public static void EnableMouse(bool enable)
        {
            // every type of device has a hard-coded GUID, this is the one for mice
            Guid mouseGuid = new Guid("{4d36e96f-e325-11ce-bfc1-08002be10318}");

            // get this from the properties dialog box of this device in Device Manager
            string instancePath = @"ACPI\PNP0F03\4&3688D3F&0";

            DeviceHelper.SetDeviceEnabled(mouseGuid, instancePath, enable);
        }
    }
}
