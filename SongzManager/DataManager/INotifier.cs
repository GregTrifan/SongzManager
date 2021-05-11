namespace SongzManager.DataManager
{
    public interface INotifier
    {
        bool SendMessage(string message);
    }
}