# Proje Açıklaması

Bu projede, bir teknoloji mağazasında kullanılan telefon ve bilgisayar kayıtlarını yönetmek için bir nesne yönelimli program tasarlamış bulunmaktayız. Proje, kullanıcıdan alınan bilgilerle telefon ve bilgisayar nesneleri oluşturarak bu nesnelerin özelliklerini yönetmeyi amaçlamaktadır. Program, temel nesne yönelimli programlama kavramlarını kullanarak, kalıtım (inheritance), kapsülleme (encapsulation), çok biçimlilik (polymorphism) ve soyutlama (abstraction) gibi prensipleri içermektedir.

## Projenin Özellikleri

- **Base Class (BaseMakine)**: Ortak özellikleri içeren bir temel sınıf.
- **Telefon Sınıfı**: BaseMakine'den türetilmiş, telefonlara özgü özellikler eklenmiş.
- **Bilgisayar Sınıfı**: BaseMakine'den türetilmiş, bilgisayarlara özgü özellikler eklenmiş.
- **Üretim Tarihi**: Nesne oluşturulduğunda otomatik olarak atanır.
- **USB Giriş Sayısı Kontrolü**: Bilgisayar sınıfında 2 veya 4 değerleri dışında bir değer girilirse hata mesajı gösterir ve -1 atanır.
- **Bilgileri Yazdırma Metodu**: BaseMakine'de tanımlanan metot, türetilen sınıflarda ezilerek (override) özelleştirilmiştir.
- **UrunAdiGetir Metodu**: Soyut bir metot olarak tanımlanmış ve türetilen sınıflarda kendine özgü bir şekilde uygulanmıştır.

## Kullanım Talimatları

1. Programı başlatın.
2. Konsol ekranında, telefon üretmek için `1`, bilgisayar üretmek için `2` tuşuna basın.
3. Seçiminize göre gerekli özellikleri girin.
4. Ürün başarıyla üretildiğinde, başka bir ürün üretmek isteyip istemediğiniz sorulacak.
5. Evet cevabı verirseniz işlemler tekrarlanacak, hayır cevabı verirseniz program sona erecektir.
