Console.WriteLine("****Günlük Koşu Mesafe Ölçer Uygulaması****");


double adimUzunlugu;
int bolumAdet;
double toplamMesafe = 0;

#region Kullanıcı Temel Veri Girişi:
Console.Write("Lütfen bir adım uzunluğunuzu giriniz: ");
while (!double.TryParse(Console.ReadLine(), out adimUzunlugu))
{
    Console.Write("Lütfen bir sayı giriniz!!! ");
}

Console.Write("Koşunun kaç bölümden oluştuğunu tam sayı olacak şekilde bir değer girerek belirtiniz: ");
while (!int.TryParse(Console.ReadLine(), out bolumAdet) || bolumAdet <= 0)
{
    Console.Write("Lütfen tam sayı değeri giriniz!!!");
}

#endregion



#region Koşu Bölüm Veri Girişi Ve Mesafe Hesaplama:
for (int i = 1; i <= bolumAdet; i++)
{
    int saat, dakika, dakikaAdimSayisi; // saat(0-23 arasında olacak), dakika(0-59 arasında olacak)


    Console.WriteLine(new string('*', 60)); // Görsel amaçlı kullanıcıya sorulan sorular * şeridiyle birbirinden ayrıldı.

    Console.WriteLine($"Bölüm {i}:");
    Console.Write("Saat giriniz (gireceğiniz sayı 0 - 23 arasında tamsayı değeri olmalıdır!!): ");
    while (!int.TryParse(Console.ReadLine(), out saat) || saat < 0 || saat > 23)
    {
        Console.Write("Lütfen 0 ile 23 arasında bir değer giriniz: ");
    }

    Console.Write("Dakika giriniz (gireceğiniz sayı 0-59 arasında tam sayı değeri olmalıdır ): ");
    while (!int.TryParse(Console.ReadLine(), out dakika) || dakika < 0 || dakika > 59)
    {
        Console.Write("Lütfen 0 ile 59 arasında bir değer giriniz: ");
    }

    Console.Write("Dakikada kaç adım attığınızı giriniz: ");
    while (!int.TryParse(Console.ReadLine(), out dakikaAdimSayisi) || dakikaAdimSayisi <= 0)
    {
        Console.Write("Lütfen pozitif bir tam sayı giriniz!!! ");
    }






    Console.WriteLine(new string('*', 60)); // Görsel amaçlı kullanıcıya sorulan sorular * şeridiyle birbirinden ayrıldı.



    int toplamSure = (saat * 60) + dakika; // toplam süreyi saati dakika formatına çevirerek ve girilen dakikayla toplayarak bulduk, int değer türünde toplamSure'ye atadık.

    double bolumMesafe = adimUzunlugu * dakikaAdimSayisi * toplamSure / 10000;// kilometre cinsinden çıktı alabilmek için bu hesaplamayı yaptık ve double değişkeninde bolumMesafe ye atadık.
    toplamMesafe += bolumMesafe;
    Console.WriteLine($"Toplam koşu mesafeniz: {toplamMesafe} kilometredir..");
}

#endregion











