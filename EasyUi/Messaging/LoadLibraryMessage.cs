namespace Messaging
{
    public class LoadLibraryMessage
    {
        public string Path { get; private set; }
        public LoadLibraryMessage(string path)
        {
            Path = path;
        }
    }
}