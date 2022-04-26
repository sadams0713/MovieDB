using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database
{
    public class Movies
    {
        public string title { get; set; }
        public string category { get; set; }

        public Movies(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
    }
    
}

