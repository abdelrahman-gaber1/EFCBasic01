using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFCBasic01
{
    internal class Course
    {
        public int Id { get; set; }

        public DateTime Duration { get; set; }

        public string Name { get; set; }    

        public string Description { get; set; }

        public int Top_Id { get; set; } 


    }
}
