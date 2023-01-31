
namespace YouTubeSave
{
    class DownloadVideoCommand : ICommand
    {
        VideoPlayer videoPlayer;

        public DownloadVideoCommand(VideoPlayer videoPlayer)
        {
            this.videoPlayer = videoPlayer;
        }
        public async Task ExecuteAsync()
        {
            await videoPlayer.DownloadVideoAsync();
        }
    }
}
