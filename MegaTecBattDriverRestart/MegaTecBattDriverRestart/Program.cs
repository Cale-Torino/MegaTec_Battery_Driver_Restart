using System;
using static MegaTecBattDriverRestart.DisableDevice;
using static MegaTecBattDriverRestart.DisableDevice2;

namespace MegaTecBattDriverRestart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine($"Parameter count = {args.Length}");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg[{i}] = [{args[i]}]");
            }
            Console.WriteLine("----------------------------------------------");
            if (args.Length > 0)
            {
                Callmethods(args[0], args[1], args[2]);
                Console.WriteLine("Process Complete!");
                Console.Beep();
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed Please Add Switch!");
                Console.Beep();
                Console.ReadKey();
            }
        }

        public static void Callmethods(string arg, string arg1, string arg2)
        {
            if (arg == "Enable")
            {
                Guid classGuid = new Guid(arg1);
                DisableorEnable(classGuid, arg2, true);
            }
            else if (arg == "Disable") 
            {
                Guid classGuid = new Guid(arg1);
                DisableorEnable(classGuid, arg2, true);
            }
            else if (arg == "Toggle")
            {
                Guid classGuid = new Guid(arg1);
                Toggle(classGuid, arg2);
            }
            else if (arg == "ToggleMegaTec")
            {
                ToggleMegaTec();
            }
            else
            {
                Console.WriteLine("Invalid Arg!");
            }
        }

        public static void Toggle(Guid classGuid, string instanceId)
        {
            DeviceHelper2.ToggleDeviceEnabled(classGuid, instanceId);
        }

        public static void DisableorEnable(Guid classGuid, string instanceId, bool enable)
        {
            DeviceHelper.SetDeviceEnabled(classGuid, instanceId, enable);
        }

        public static void ToggleMegaTec()
        {
            Guid classGuid = new Guid("{745a17a0-74d3-11d0-b6fe-00a0c90f57da}");
            string instanceId = @"HID\VID_0001&PID_0000\6&7EFA158&0&0000";
            DeviceHelper2.ToggleDeviceEnabled(classGuid, instanceId);
        }

        public static void Disab()
        {
            string instanceId = @"VID_0001&PID_0000";
            DisableHardwareClass.EnableDevice(n => n.ToUpperInvariant().Contains(instanceId), true);
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
