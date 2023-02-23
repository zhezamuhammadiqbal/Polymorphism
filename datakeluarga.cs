using System;
public class HelloWorld
{
    static public void Main()
    {
        familyhobi ak = new familyhobi();
        familyhobi kakak = new ayah();
        familyhobi ibu = new Ibu();
        familyhobi anak = new Anak();

        familydata ayah = new familydata("Achmad Soharnoto", 47, 6281334934887);
        familydata ibuku = new familydata("Anissa ", 45, 6282336669972);
        familydata aku = new familydata("Zheza M Iqbal", 16, 6282230132607);
        Console.WriteLine("DATA AYAH:\n" + ayah.nama + "\n" + ayah.umur + "\n" + ayah.nohp);
        kakak.Hobi();
        Console.WriteLine("DATA IBU:\n" + ibuku.nama + "\n" + ibuku.umur + "\n" + ibuku.nohp);
        ibu.Hobi();
        Console.WriteLine("DATA ANAK:\n" + aku.nama + "\n" + aku.umur + "\n" + aku.nohp);
        anak.Hobi();
    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;
        public familydata(string Nama, int Umur, long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }
    }
    class familyhobi
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class ayah : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Basket");
        }
    }
    class Ibu : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Belanja,Shoping,Healing");
        }
    }
    class Anak : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Sepak Bola");
        }
    }
}
