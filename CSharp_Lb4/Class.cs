using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lb4
{
    class Track
    {
        public string name { get; set; } = String.Empty;
        public int minutes { get; set; } = 0;
        public int seconds { get; set; } = 0;
    }
    class Album
    {
        public string name { get; set; } = String.Empty;
        public int year { get; set; } = 0;
        public List<string> genres { get; set; } = new List<string>();
        public List<Track> tracks { get; set; } = new List<Track>();
    }
    class Executor
    {
        public string name { get; set; } = String.Empty;
        public List<Album> albums { get; set; } = new List<Album>();
    }
}
