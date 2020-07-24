using System;
using System.Collections.Generic;

namespace YouTube
{
    public class Profile : Video
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Video> MyVideos { get; set; }
    }
}