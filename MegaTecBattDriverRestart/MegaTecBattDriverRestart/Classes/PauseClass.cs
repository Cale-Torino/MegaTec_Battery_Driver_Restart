using System;

namespace MegaTecBattDriverRestart
{
    internal class PauseClass
    {
        public static void Pause() 
        {
            Console.Beep();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
