
namespace YouTubeSave
{
    class GetVideoInfoCommand : ICommand
    {
        VideoPlayer videoPlayer;

        public GetVideoInfoCommand(VideoPlayer videoPlayer)
        {
            this.videoPlayer = videoPlayer;
        }

        public async Task ExecuteAsync()
        {
            await videoPlayer.GetVideoInfoAsync();
        }
    }
}
