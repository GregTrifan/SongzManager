using SongzManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SongzManager.DataManager
{
    public interface IMusicManager
    {
        INotifier Notify { get; set; }
        List<SongModel> GetMusic();
        List<SongModel> GetMusicThenNotify();
        Task<int> GetMusicCount();
    }
}