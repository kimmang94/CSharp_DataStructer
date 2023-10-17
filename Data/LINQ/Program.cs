using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profile[] profiles = 
            { 
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 170 },
                new Profile() { Name = "고윤정", Height = 158 },
                new Profile() { Name = "한효주", Height = 172 },
                new Profile() { Name = "이문세", Height = 170 },
                new Profile() { Name = "강동원", Height = 192 }
            };


            var profilesData = from profile in profiles
                               where profile.Height < 175
                               orderby profile.Height
                               select profile;

            foreach ( var profile in profilesData )
            {
                Console.WriteLine($"{profile.Name}, {profile.Height}");
            }

            Console.ReadKey();
        }
    }

    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
}
