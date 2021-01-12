using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBrowser.Controller.Entities
{
    /// <summary>
    /// Interface for those entities which have metadata properties related to moderation (minimum time between replays).
    /// </summary>
    public interface IHasMinHoursBetweenReplays
    {
        /// <summary>
        /// Gets or sets the minimum hours between replays.
        /// </summary>
        int MinHoursBetweenReplays { get; set; }
    }
}
