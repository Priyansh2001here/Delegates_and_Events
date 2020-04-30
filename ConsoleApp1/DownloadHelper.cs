using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{

    class DownloadHelper
    {
        
        public class FileEventArgs:EventArgs
        {
            public File file { get; set; }
        }
         
        
        public delegate void FileDownloadEventHandler(object source, FileEventArgs args);

        // public event FileDownloadEventHandler FileDownloaded;
        //OR
        public event EventHandler<FileEventArgs> FileDownloaded;

        protected virtual void OnFileDownloaded(File file)       // this is how to add event
        {
            if (FileDownloaded != null)
            {
                var fileEv = new FileEventArgs();
                fileEv.file = file;
                FileDownloaded(this, fileEv);
            }
        }

        public void Download(File file)
        {
            Console.WriteLine("Downloading File .....");
            Thread.Sleep(4000);

            OnFileDownloaded(file);

        }

    }
}
