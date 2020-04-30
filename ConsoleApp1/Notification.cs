using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Notification
    {
        public void onDownloadedNotif(object source, DownloadHelper.FileEventArgs e)
        {
            Console.WriteLine("File Has been Downloaded"  + e.file.Title);
        }
    }
}
