using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemMonitor
{
    public enum EventAction
    {
        Notify,
        Restart,
        Shutdown,
        Crash
    }

    public enum Severity
    {
        Debug,
        Verbose,
        Info,
        Notice,
        Warning,
        Error,
        Critical,
        Fatal
    }

    public enum SystemState
    {
        Normal,
        Stressed,
        Overloaded,
        Emergency
    }

    public class Dispatcher
    {
        public static void OverTemperatureEvent()
        {

        }

        public static void OverVoltageEvent()
        {

        }

        public static void NetworkConnectivityLossEvent()
        {

        }

        public static void FanFailureEvent()
        {

        }

        public static void DiskFailure()
        {

        }

        public static void MemoryUsageCriticalEvent()
        {

        }

        public static void ExcessPowerUsageEvent()
        {

        }

        public static void Method()
        {

        }

        public static void Method()
        {

        }

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

        static void CriticalShutdown(string[] args)
        {
            int isCritical = 1;  // we want this to be a Critical Process
            int BreakOnTermination = 0x1D;  // value for BreakOnTermination (flag)

            Process.EnterDebugMode();  //acquire Debug Privileges

            // setting the BreakOnTermination = 1 for the current process
            NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));
        }
    }
}
