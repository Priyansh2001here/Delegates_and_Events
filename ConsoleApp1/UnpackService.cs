using System;
using System.Threading;

namespace ConsoleApp1
{
    public class UnpackService
    {
        public void OnFileDownloaded(object source, EventArgs e)
        {
            Console.WriteLine("Unpacking service: Unpacking FIle ...");

            Thread.Sleep(400);
        }
    }

}
