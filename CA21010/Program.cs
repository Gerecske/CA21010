namespace CA21010
{
    public abstract class Jarmu
    {
        public int TankMerete { get; set; }

        public float BenzinMeny { get; set; }
        public int SzallSzemSzam { get; set; }

        public abstract void Tankol(float benzin);
    }

    public class Gapkocsi : Jarmu
    {
        public override void Tankol(float benzin)
        {
            throw new NotImplementedException();
        }

        public Gapkocsi()
        {
            TankMerete = 80;
            SzallSzemSzam = 5;
        }
    }

    public class Motorkerekpar : Jarmu
    {
        public override void Tankol(float benzin)
        {
            if (BenzinMeny + benzin <= TankMerete)
            {
                BenzinMeny += benzin;
            }
            else
            {
                Console.WriteLine($"Tank tele maradt még {BenzinMeny + benzin - TankMerete} liter benzin!");
                BenzinMeny = TankMerete;
            }
        }

        public Motorkerekpar()
        {
            TankMerete = 15;
            SzallSzemSzam = 2;
        }
    }

    public class Tesla : Jarmu
    {
        public override void Tankol(float benzin)
        {
            Console.WriteLine($"nem kell a {benzin} liter benzin,\nDugd be a konekorba");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Jarmu g1 = new Gapkocsi();
            Jarmu g2 = new Motorkerekpar();
        }
    }
}