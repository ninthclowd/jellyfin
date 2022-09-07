using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBrowser.Controller.Entities
{
    /// <summary>
    ///
    /// </summary>
    public interface IHasMinHoursBetweenReplay
    {
        /// <summary>
        /// Gets or sets the minimum hours between replays
        /// </summary>
        int MinHoursBetweenReplays { get; set; }
    }
}
