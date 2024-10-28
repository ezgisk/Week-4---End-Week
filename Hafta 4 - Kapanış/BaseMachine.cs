using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_4___Kapanış
{
    public abstract class BaseMachine
    {
        public DateTime ProductionDate { get; set; }
        public string Serialnumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        protected BaseMachine()
        {
            ProductionDate = DateTime.Now;
        }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {ProductionDate}");
            Console.WriteLine($"Seri Numarası: {Serialnumber}");
            Console.WriteLine($"Ad: {Name}");
            Console.WriteLine($"Açıklama: {Description}");
            Console.WriteLine($"İşletim Sistemi: {OperatingSystem}");
        }
       public abstract void UrunAdiGetir();
    }
}
