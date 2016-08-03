using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
    // Must rebuild project before you create controllers, or after you do anything

    //What is a model: 
    public class Album
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }

        public Artist Artist { get; set; }

        public int ReviewID { get; set; }

        // why is it virtual???
        public virtual List<Review> Review { get; set; }
    }
}