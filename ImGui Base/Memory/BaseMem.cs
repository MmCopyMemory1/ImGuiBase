using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImGuiMemory
{
    public class BaseMem
    {
        public static bool BaseWriteToMem(IntPtr gameProc, IntPtr address, int val)
        {
            byte[] buffer = BitConverter.GetBytes(val);
            IntPtr bytesWritten;

            bool result = WriteProcessMemory(gameProc, address, buffer, buffer.Length, out bytesWritten);

            if (!result)
            {
                Console.WriteLine($"Write failed. Error code: {Marshal.GetLastWin32Error()}");
            }

            return result;
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(
        IntPtr hProcess,
        IntPtr lpBaseAddress,
        byte[] lpBuffer,
        int nSize,
        out IntPtr lpNumberOfBytesWritten);
    }
}
