using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YouTubeSave
{
    class VideoPlayer
    {
        public string videoUrl { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        YoutubeClient youtube = new YoutubeClient();
        public async Task GetVideoInfoAsync()
        {
            var video = await youtube.Videos.GetAsync(videoUrl);

            title = video.Title; 
            description = video.Description;

            Console.WriteLine($"Название: {title}");
            Console.WriteLine($"Описание: {description}");
        }

        public async Task DownloadVideoAsync()
        {
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
            Console.WriteLine($"Скачивание видео '{title}' завершено!");
        }
    }
}
