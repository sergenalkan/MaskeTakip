

using Business.Concrete;
using Entities.Concrete;

class Program
{
    private static void Main(string[] args)
    {
        //Degiskenler();
        //Vatandas vatandas1 = new Vatandas();

        SelamVer("Engin");
        SelamVer("Ediz");
        SelamVer("Ayşe");
        SelamVer();

        int sonuc = Topla(6,50);

        //Diziler - Arrays

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";
        ogrenciler=new string[4];
        ogrenciler[3] = "İlker";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        sehirler2 = sehirler1;//s2 s1in referansını alır, haliyle altta adana yazacak
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);

        //int, double, bool: değer tipler. sadece stackte takılırlar
        //int sayi1 = 10;
        //int sayi2 = 20;
        //sayi2 = sayi1;
        //sayi1 = 30;
        //Console.WriteLine(sayi2);
        //string: referans tip ama değer tip gibi çalışır. Aslında char arraydir

        Person person1=new Person();
        person1.FirstName = "ENGİN";
        person1.LastName = "DEMİROĞ";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentity = 123;

        Person person2 = new Person();
        person2.FirstName = "Murat";

        foreach (string s in sehirler1)
        {
            Console.WriteLine(s);
        }
        //MyList
        List<string> yeniSehirler1 = new List<string> { "Ankara 1","İzmir 1","İstanbul 1"};
        yeniSehirler1.Add("Adana 1");

        foreach (string sehir in yeniSehirler1)
        {  
            Console.WriteLine(sehir); 
        }

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

        Console.ReadLine();

    }

    static void SelamVer(string isim="isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }
    //default değerler sona yazılır
    static int Topla(int sayi1=5, int sayi2=15)
    {
        int sonuc=sayi1 + sayi2;
        Console.WriteLine("Toplam :"+sonuc.ToString());
        return sonuc;
    }
    //static void Degiskenler()
    //{
    //    string mesaj = "Selam";
    //    double tutar = 100000; //dbden gelir
    //    int sayi = 100;
    //    bool girisYapmisMi = false;


    //    string ad = "Engin";
    //    string soyad = "Demiroğ";
    //    int dogumYili = 1985;
    //    long tcNo = 12345678910; //string olarak da verebilirsin. Long daha uzun


    //    Console.WriteLine(tutar * 1.18);
    //}
}

//pascal casing
//public class Vatandas
//{
//    public string Ad { get; set; }
//    public string Soyad { get; set; }
//    public int DogumYili { get; set; }
//    public long TcNo { get; set; }
//}