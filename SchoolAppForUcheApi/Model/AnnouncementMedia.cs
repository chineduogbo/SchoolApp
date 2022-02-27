using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppForUcheApi.Model
{
    public class AnnouncementMedia
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int AnnouncementsId { get; set; }
        public virtual Announcements Announcements { get; set; }
        public bool Active { get; set; }

    }
}
