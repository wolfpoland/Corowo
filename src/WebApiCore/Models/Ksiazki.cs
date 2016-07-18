using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class Ksiazki
    {
        public string Tytul { get; set; }
        public string ISBN { get; set; }
        public bool Przeczytana { get; set; }
    }
}
