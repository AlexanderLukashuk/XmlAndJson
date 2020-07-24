using System;
using System.Collections.Generic;

namespace YouTube
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile user1 = new Profile();
            Profile user2 = new Profile();
            List<Profile> users = new List<Profile> { user1, user2 };
        }
    }
}
