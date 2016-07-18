using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class KsiazkiImplementacja : IKsiazkiRepository
    {
        List<Ksiazki> lista = new List<Ksiazki>();
        public void Add(Ksiazki k)
        {
            lista.Add(k);    
        }

        public Ksiazki Find(string klucz)
        {
           Ksiazki ks= lista.Find(k => k.ISBN == klucz);
            return ks;
        }

        public IEnumerable<Ksiazki> getAll()
        {
            return lista;
        }

        public Ksiazki Remove(string klucz)
        {
            Ksiazki ks = lista.Find(k => k.ISBN == klucz);
            lista.Remove(ks);
            return ks;
        }

        public void Update(Ksiazki item)
        {
            int n = 0;
            foreach (Ksiazki itemo in lista)
            {
                if(itemo.ISBN== item.ISBN || itemo.Tytul == item.Tytul)
                {
                    lista.Remove(itemo);
                    lista.Insert(n, itemo);
                }
                n++;
            }
        }
    }
}
