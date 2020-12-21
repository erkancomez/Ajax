using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    public class KullaniciIslem
    {
        private static readonly List<Kullanici> kullanicilar = new List<Kullanici>
        { 
            new Kullanici{Id=1, Ad="kullanici1"},
            new Kullanici{Id=2, Ad="kullanici2"}
        };
        
        public static List<Kullanici> GetAll()
        {
            return kullanicilar;
        }
        public static Kullanici GetById(int Id)
        {
            return kullanicilar.FirstOrDefault(I => I.Id == Id);
        }
        public static void Add(Kullanici kullanici)
        {
            kullanicilar.Add(kullanici);
        }

    }
}
