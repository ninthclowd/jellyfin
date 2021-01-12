using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBrowser.Controller.Entities
{
    /// <summary>
    /// Interface for those entities which can be moderated (minimum time between replays).
    /// </summary>
    public interface IHasCanReplay
    {
        /// <summary>
        /// Whether or not a user can replay this item.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool CanReplay(Jellyfin.Data.Entities.User user);
    }
}
