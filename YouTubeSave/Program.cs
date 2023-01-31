using System;
using YoutubeExplode;

namespace YouTubeSave
{
    class Program
    {
        static async Task Main()
        {
            var sender = new Sender();

            var videoPlayer = new VideoPlayer();

            Console.WriteLine("Введите Url видео:");
            videoPlayer.videoUrl = Console.ReadLine();

            var getVideoInfoCommand = new GetVideoInfoCommand(videoPlayer);
            var downloadVideoCommand = new DownloadVideoCommand(videoPlayer);

            sender.SetCommand(getVideoInfoCommand);

            await sender.Run();

            sender.SetCommand(downloadVideoCommand);

            await sender.Run();
        }
    }
}