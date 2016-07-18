using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    interface IKsiazkiRepository
    {
        void Add(Ksiazki k);
        IEnumerable<Ksiazki> getAll();
        Ksiazki Find(string klucz);
        Ksiazki Remove(string klucz);
        void Update(Ksiazki item);

    }
}
