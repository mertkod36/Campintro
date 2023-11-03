using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Musteri
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Firstname { get; internal set; }
        public string Lastname { get; set; }
        public string LastName { get; internal set; }
    }
}
