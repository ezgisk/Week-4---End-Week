using Hafta_4___Kapanış;
using System.Numerics;
bool choice = true;
while (choice)
{
    Console.WriteLine("Telefon üretmek için 1 bilgisayar üretmek için 2'ye basin.");
    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.WriteLine("Telefon üretiyorsunuz...");
        Phone phone = new Phone();
        Console.Write("Seri Numarası: ");
        phone.Serialnumber = Console.ReadLine();
        Console.Write("Ad: ");
        phone.Name = Console.ReadLine();
        Console.Write("Açıklama: ");
        phone.Description = Console.ReadLine();
        Console.Write("İşletim Sistemi: ");
        phone.OperatingSystem = Console.ReadLine();
        Console.Write("Türkiye Lisanslı mı? (true/false): ");
        ((Phone)phone).Licanced = Convert.ToBoolean(Console.ReadLine());
        phone.BilgileriYazdir();
        phone.UrunAdiGetir();
        Console.WriteLine("Ürün başarıyla üretildi!");

    }
    else if (input == "2")
    {
        Console.WriteLine("Bilgisayar üretiyorsunuz...");
        Computer computer = new Computer();
        Console.Write("Seri Numarası: ");
        computer.Serialnumber = Console.ReadLine();
        Console.Write("Ad: ");
        computer.Name = Console.ReadLine();
        Console.Write("Açıklama: ");
        computer.Description = Console.ReadLine();
        Console.Write("İşletim Sistemi: ");
        computer.OperatingSystem = Console.ReadLine();
        Console.Write("USB Giriş Sayısı (2 veya 4): ");
        ((Computer)computer).UsbCount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bluetooth var mı? (true/false): ");
        ((Computer)computer).Bluetooth = Convert.ToBoolean(Console.ReadLine());
        computer.BilgileriYazdir();
        computer.UrunAdiGetir();
        Console.WriteLine("Ürün başarıyla üretildi!");
    }
    else
    {
        Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2'ye basın.");
    }

    Console.Write("Başka bir ürün üretmek ister misiniz? (evet/hayır): ");
    choice = Console.ReadLine().ToLower() == "evet";
}



Console.ReadKey();