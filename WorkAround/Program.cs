using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "MUSTAFA ÖNDER";
        person.LastName = "ÜNLÜ";
        person.NationalIdentitiy = 1651;
        person.DateOfBirthYear = 2002;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);

        //Console.WriteLine("Merhabalar");

        //Vatandas vatandas1 = new Vatandas();

        //string mesaj = "Hi";

        //if (string.IsNullOrEmpty(mesaj))
        //    Console.WriteLine("Boş");
        //else Console.WriteLine("Hi");

        ////degiskenler();

        //static void degiskenler()
        //{
        //    string mesaj2 = "merhaba";
        //    double tutar = 0; // databaseden gelecek
        //    int sayi = 0;
        //    bool isLogin = false;

        //    string ad = "asds";
        //    string soyad = "123";
        //    long tcNo = 12345678900;
        //    int DogumYili = 1985;

        //    Console.WriteLine(tutar * 1.18);
        //    Console.WriteLine(tutar * 1.18);
        //}
        //static int topla(int sayi1, int sayi2)
        //{
        //    int sonuc = sayi1 + sayi2;
        //    //Console.WriteLine(sonuc.ToString());
        //    return sonuc;
        //}
        //static void SelamVer(string mesaj)
        //{
        //    Console.WriteLine(mesaj + " Merhaba, toplam = " + topla(1, 4));
        //}
        //static void SelamVera(string mesaj)
        //{
        //    Console.WriteLine(mesaj + " Merhaba, toplam = " + topla(17, 4));
        //}
        ////topla(sayi1: 3, sayi2:1) ;
        //SelamVer(mesaj);
        //SelamVera(mesaj);


        ////garbage Collector
        ////array, class, abstrack, interface referans tpli metodlar
        ////int, double, bool, float sayı değer tipli değişkenlerdir.

        //string[] sehirler1 = new[] { "Ankara", "İzmir", "İstanbul" };
        //string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        //sehirler2 = sehirler1; //burada olan şey sehirler2 sehirler1 in referansıdır
        //sehirler1[0] = "Adana";
        //Console.WriteLine(sehirler2[0]);// sonuç adana

        //int sayi1 = 20;
        //int sayi2 = 10;
        //sayi2 = sayi1;
        //sayi1 = 30;
        //Console.WriteLine(sayi2);


    }
}