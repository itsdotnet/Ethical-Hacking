using System.Runtime.InteropServices;

namespace Windows_Activator;
class Program
{
    [DllImport("kernel32.dll")]
    private static extern bool AllocConsole();

    [DllImport("kernel32.dll")]
    private static extern bool FreeConsole();

    static void Main()
    {
        // Hide the console window

        FreeConsole();

        Pic pic = new Pic();

    }
}