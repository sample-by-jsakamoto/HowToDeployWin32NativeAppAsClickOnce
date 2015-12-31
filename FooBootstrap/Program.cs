using System;
using System.Diagnostics;
using System.IO;

static class Program
{
    [STAThread]
    static void Main()
    {
        var baseDir = AppDomain.CurrentDomain.BaseDirectory;
        var exePath = Path.Combine(baseDir, "foo.exe");
        Process.Start(exePath);
    }
}
