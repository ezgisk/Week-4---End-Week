using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_4___Kapanış
{
    public class Computer : BaseMachine
    {
        //Creating computer class
        private int usbCount;
        public int UsbCount
        {
            get { return usbCount; }
            set
            {
                if (value != 2 || value != 4)//Checking the usb count
                {
                   usbCount = value;
                }
                else
                {
                    Console.WriteLine("USB Count can be 2 or 4");
                    value = -1;
                }
            }
        }
        public bool Bluetooth { get; set; }

        public override void BilgileriYazdir()//override method the base class
        {
            Console.WriteLine($"Bilgisayarin uretim tarihi:{ProductionDate}\nBilgisayarin seri numarasi:{Serialnumber}\n Bilgisayarin adi:{Name}\n Aciklama:{Description}\n Isletim Sistemi:{OperatingSystem}\n USB Giris sayisi:{UsbCount}\n Bluetooth:{(Bluetooth ? "Var" : "Yok")}");
        }

        public override void UrunAdiGetir()//override method the base class
        {
            Console.WriteLine($"Bilgisayarınızın adı --->{Name}");
        }
    }
}
