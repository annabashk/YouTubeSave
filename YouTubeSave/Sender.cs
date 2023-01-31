
namespace YouTubeSave
{
    class Sender
    {
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public async Task Run()
        {
            await _command.ExecuteAsync();
        }
    }
}
