namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new File() { Title = "File1" };
            var downloadHelper = new DownloadHelper();          
            var unpackService = new UnpackService();
            var notifLed = new Notification();

            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded;
            downloadHelper.FileDownloaded += notifLed.onDownloadedNotif;

            // event+=


            downloadHelper.Download(file);

        }
    }

}
