using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_4___Kapanış
{
    public class Phone : BaseMachine
    {
        //Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi, Tr Lisanslı 

        public bool Licanced { get; set; }

        public override void BilgileriYazdir()//override method the base class
        {
            Console.WriteLine($"Telefonun uretim tarihi:{ProductionDate}\nTelefonun seri numarasi:{Serialnumber}\nTelefonun adi:{Name}\nAciklama:{Description}\nIsletim Sistemi:{OperatingSystem}\nLisansli:{((Licanced) ? "Evet" : "Hayır")}");
        }

        public override void UrunAdiGetir()//override method the base class
        {
            Console.WriteLine($"Telefonunuzun adı --->{Name}");
        }
    }

}
