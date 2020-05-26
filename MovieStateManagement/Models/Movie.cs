using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStateManagement.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }

        public Movie(string title, int runTime)
        {
            Title = title;
            RunTime = runTime;
        }

        public Movie()
        {

        }
    }
}
