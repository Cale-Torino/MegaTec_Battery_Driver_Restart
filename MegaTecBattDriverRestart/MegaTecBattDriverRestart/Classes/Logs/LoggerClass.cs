﻿using System;
using System.IO;

namespace MegaTecBattDriverRestart
{
    internal class LoggerClass
    {
        //Create logfile log. file
        internal static string LogFile { get; set; } = $@"{AppDomain.CurrentDomain.BaseDirectory}Logs\{AppDomain.CurrentDomain.FriendlyName}_{DateTime.Now:yyyy-dd-M--HH-mm-ss}.log";

        internal static void WriteLine(string txt)
        {
            try
            {
                //Write to the logfile
                File.AppendAllText(LogFile, $"[{DateTime.Now}] : {txt}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        internal static void DeleteLog()
        {
            try
            {
                //Delete the log file
                File.Delete(LogFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

    }
}
