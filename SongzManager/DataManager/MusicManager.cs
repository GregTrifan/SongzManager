using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SongzManager.Models;
namespace SongzManager.DataManager
{
    public class MusicManager : IMusicManager
    {
        public INotifier Notify { get; set; }
        public List<SongModel> GetMusic()
        {
            return new List<SongModel>
            {
                new SongModel {Id=1,Title="Rap God", Artist="Eminem",Genre="Hip Hop"},
                new SongModel {Id=2,Title="Stronger",Artist="Kanye West", Genre="Hip Hop"},
                new SongModel {Id=3, Title="Blind",Artist="Lifehouse",Genre="Alternative"},
                new SongModel {Id=4, Title="Hey Jude",Artist="The Beatles", Genre="Rock n Roll"}
            };
        }
        public List<SongModel> GetMusicThenNotify()
        {
            // Invoke Notifier
            if (Notify != default)
            {
                Notify.SendMessage("User viewed the music list page");
            }
            return GetMusic();
        }
        public async Task<int> GetMusicCount()
        {
            return await Task.FromResult(GetMusic().Count);
        }
    }
}
