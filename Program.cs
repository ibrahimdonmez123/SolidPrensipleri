using System;
using System.Collections.Generic;

// Single Responsibility Principle (SRP)
public class DosyaYoneticisi
{
    public void DosyayiKaydet(string veri, string dosyayolu)
    {
        // Dosyaya veriyi kaydetme işlemi
    }

    public string DosyayiOku(string dosyayolu)
    {
        // Dosyadan veri okuma işlemi
        return null;
    }
}

// Veriİslemcisi sadece veri işleme ile ilgilenir.
public class Veriİslemcisi
{
    public void Veriyiİsle(string veri)
    {
        // Veriyi işleme işlemi
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Open/Closed Principle (OCP)
public abstract class Sekil
{
    public abstract double Alan();
}

public class Dikdortgen : Sekil
{
    public double Genislik { get; set; }
    public double Uzunluk { get; set; }

    public override double Alan()
    {
        return Genislik * Uzunluk;
    }
}

public class Cember : Sekil
{
    public double Cap { get; set; }

    public override double Alan()
    {
        return Math.PI * Cap * Cap;
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Liskov Substitution Principle (LSP)
public class Kus
{
    public virtual void Uc()
    {
        Console.WriteLine("Ucuyor...");
    }
}

public class Kopek : Kus
{
    public override void Uc()
    {
        Console.WriteLine("Köpekler uçamaz.");
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Interface Segregation Principle (ISP)
public interface ICalisan
{
    void Calis();
    void Ye();
}

public class Robot : ICalisan
{
    public void Calis()
    {
        // Robot çalışma işlemi
    }

    public void Ye()
    {
        // Robot yemek yeme işlemi
    }
}

public class Insan : ICalisan
{
    public void Calis()
    {
        // İnsan çalışma işlemi
    }

    public void Ye()
    {
        // İnsan yemek yeme işlemi
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Dependency Inversion Principle (DIP)
public interface IMesajYollayici
{
    void MesajYolla(string mesaj);
}

public class EmailYollayici : IMesajYollayici
{
    public void MesajYolla(string mesaj)
    {
        // Email gönderme işlemi
    }
}

public class BildirimmHizmeti
{
    private readonly IMesajYollayici _mesajYollayici;

    public BildirimmHizmeti(IMesajYollayici mesajYollayici)
    {
        _mesajYollayici = mesajYollayici;
    }

    public void BildirimYolla(string mesaj)
    {
        _mesajYollayici.MesajYolla(mesaj);
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////








class Program
{
    static void Main()
    {
        //var dosyaYoneticisi = new DosyaYoneticisi();
        //var veriİslemcisi = new Veriİslemcisi();

        //var dikdortgen = new Dikdortgen { Genislik = 5, Uzunluk = 10 };
        //var cember = new Cember { Cap = 7 };

        //var sekiller = new List<Sekil> { dikdortgen, cember };

        //foreach (var sekil in sekiller)
        //{
        //    Console.WriteLine($"Alanı: {sekil.Alan()}");
        //}

        //var kus = new Kus();
        //kus.Uc(); 

        //var kopek = new Kopek();
        //kopek.Uc(); 

        //var robot = new Robot();
        //var insan = new Insan();

        //var emailYollayıcı = new EmailYollayici();
        //var bildirimHizmeti = new BildirimmHizmeti(emailYollayıcı);
        //bildirimHizmeti.BildirimYolla("Merhaba, SOLID!");

        //Console.ReadLine();
    }
}
