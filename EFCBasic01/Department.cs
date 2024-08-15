using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCBasic01
{
    internal class Department
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public DateTime HiringDate { get; set; }

        public int Ins_Id { get; set; }
    }
}
