using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongzManager.DataManager
{
    public class Notifier : INotifier
    {
        public bool SendMessage(string message)
        {
            // Some Logic for message
            return true;
        }
    }
}
