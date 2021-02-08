using System;

namespace calisma
{

    class Calisan
    {
        string sskNo, ad;
        int maas;
        public string SskNo
        {
            set { sskNo = value; }
            get { return sskNo; }
        }
        public string Ad
        {
            set { ad = value; }
            get { return ad; }
        }
        public int Maas
        {
            set { maas = value; }
            get { return maas; }
        }
        public virtual void zamYap(int zm)
        {
            maas += zm;

        }

        public void BilgiVer()
        {
            
            Console.Write("{0}\t{1}\t{2}", sskNo, ad, maas);
        }
    }
    class Mud : Calisan
    {
        int dkar;
        public int Dkar
        {
            set { dkar = value; }
            get { return dkar; }
        }

    }
    class SatisElemanı:Calisan
    {
        int satisSayisi;
        public int SatisSayisi
        {
            set { satisSayisi = value; }
            get { return satisSayisi; }
        }
        public override void zamYap(int zm)
        {
            Maas += Maas * 10;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Mud m1 = new Mud();
            Console.Write("Müdürün Ssk Numarasını Giriniz:\n");
            m1.SskNo = Console.ReadLine();
            Console.Write("Müdürün Adını Giriniz:\n");
            m1.Ad = Console.ReadLine();
            Console.Write("Müdürün Maaşını Giriniz:\n");
            m1.Maas = int.Parse(Console.ReadLine());
            Console.Write("Müdürün Departman Karını Giriniz:\n");
            m1.Dkar = int.Parse(Console.ReadLine());

            SatisElemanı se = new SatisElemanı();
            Console.Write("Satış Elemanının Ssk Numarasını Giriniz:\n");
            se.SskNo = Console.ReadLine();
            Console.Write("Satış Elemanının Adını Giriniz:\n");
            se.Ad = Console.ReadLine();
            Console.Write("Satış Elemanının Maaşını Giriniz:\n");
            se.Maas = int.Parse(Console.ReadLine());
            Console.Write("Satış Elemanının Satış Sayısını Giriniz:\n");
            se.SatisSayisi = int.Parse(Console.ReadLine());


            m1.zamYap(500);
            se.zamYap(100);
            Console.Write("Müdür:");
            m1.BilgiVer();
            Console.Write("\nSatış Elemanı:");
            se.BilgiVer();
            Console.ReadKey();
            



        }
    }
}

