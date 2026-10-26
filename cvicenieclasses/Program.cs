

namespace cvicenieclasses;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("biju sa");
        Hrdina nasPrvyhrdina = new Hrdina();
        nasPrvyhrdina.Meno = "ironman";
        nasPrvyhrdina.Zdravie = 50;
        nasPrvyhrdina.Energia = 150;


        Hrdina nasDruhyhrdina = new Hrdina();
        nasDruhyhrdina.Meno = "augustin";
        nasDruhyhrdina.Zdravie = 45;
        nasDruhyhrdina.Energia = 100;

        Random random = new Random();


        while (nasPrvyhrdina.Zdravie > 0 && nasDruhyhrdina.Zdravie > 0)

        {
            nasPrvyhrdina.Energia += 5;
            nasDruhyhrdina.Energia += 5;

            int silautoku = random.Next(10, 31);
            bool podarilsaUtok = nasPrvyhrdina.Utok(silautoku);
            if (podarilsaUtok)
            {
                nasDruhyhrdina.PrijmiZranenie(silautoku);
                Console.WriteLine(nasPrvyhrdina.Meno + "trafil");
            }
            else
            {
                Console.WriteLine(nasPrvyhrdina.Meno + "je unaveny");
            }

            if (nasDruhyhrdina.Zdravie == 0)
            {
                break;
            }

            silautoku = random.Next(10, 31);
            podarilsaUtok = nasDruhyhrdina.Utok(silautoku);
            if (podarilsaUtok)
            {
                nasPrvyhrdina.PrijmiZranenie(silautoku);
                Console.WriteLine(nasDruhyhrdina.Meno + "trafil");
            }
            else
            {
                Console.WriteLine(nasDruhyhrdina.Meno + "je unaveny");
            }

            nasPrvyhrdina.VypisAktualnystav();
            nasDruhyhrdina.VypisAktualnystav();
        }

        if (nasPrvyhrdina.Zdravie > 0)
        {
            Console.WriteLine("Vyhral " + nasPrvyhrdina.Meno);
        }
        else
        {
            Console.WriteLine("Vyhral " + nasDruhyhrdina.Meno);
        }
        Ucet prvyUcet = new Ucet();
        prvyUcet.cislo = "123456";
        prvyUcet.majitel = "Paulina";
        prvyUcet.zostatok = 500;
        Ucet druhyUcet = new Ucet();
        druhyUcet.cislo = "654321";
        druhyUcet.majitel = "Adam";
        druhyUcet.zostatok = 1000;
        prvyUcet.VlozPeniaze(200);
        Console.WriteLine(prvyUcet.zostatok);
        prvyUcet.VyberPeniaze(100);
        Console.WriteLine(prvyUcet.zostatok);

        prvyUcet.VyberPeniaze(1000);
        Console.WriteLine(prvyUcet.zostatok);
        druhyUcet.VlozPeniaze(300);
        Console.WriteLine(druhyUcet.zostatok);

        druhyUcet.VyberPeniaze(400);
        Console.WriteLine(druhyUcet.zostatok);

        druhyUcet.VyberPeniaze(-50);
        Console.WriteLine(druhyUcet.zostatok);

        druhyUcet.VlozPeniaze(-100);
        Console.WriteLine(druhyUcet.zostatok);
        prvyUcet.PosliPeniaze(200, druhyUcet);

        Console.WriteLine(prvyUcet.zostatok);
        Console.WriteLine(druhyUcet.zostatok);
        Datum prvyDatum = new Datum();
        prvyDatum.Den = 15;
        prvyDatum.Mesiac = 3;
        prvyDatum.Rok = 2025;

        Datum druhyDatum = new Datum();
        druhyDatum.Den = 20;
        druhyDatum.Mesiac = 3;
        druhyDatum.Rok = 2025;

        prvyDatum.Porovnaj(druhyDatum);
    }
    


    }
// 1a. Definuj triedu Hrdina: Vlastnosti:
// meno (string)
// zdravie (int) – napr. 100
// energia (int) – napr. 50
// 1b. Vytvor metódu Utok, ktorá prijíma parameter cena_energie (int).
// Metóda skontroluje, či má hrdina dostatok Energie.
// Ak áno: Odpočíta energiu a vráti true (útok sa podaril).
// Ak nie: Neodpočíta nič a vráti false (hrdina je príliš unavený).
// 1c. Vytvor metódu PrijmiZranenie, ktorá prijíma parameter sila (int).
// Odpočíta silu úderu od Zdravia.
// Ak zdravie klesne pod 0, nastaví ho na 0.
// Vráti aktuálny stav zdravia po zásahu (int).
// 1d. Hlavný program (Main): Vytvor dvoch hrdinov. V cykle simuluj boj:
// Každý hrdina sa pokúsi o útok s náročnosťou 20 (použi metódu Utok).
// Ak metóda vráti true, vypíš "Hrdina zaútočil!". Druhý hrdina dostane ekvivalentné zranenie. 
// Ak vráti false, vypíš "Hrdina musí oddychovať.".
// 1e. Sprav boj zaujímavejší.
// Uprav silu útoku (a tým aj energiu potrebnú na útok) aby bola náhodná od 10 do 30 (použi na to Random Next). 
// Každému hrdinovi sa automaticky každé kolo (každé opakovanie cyklu) doplní 5 energie. 
// Ktorý hrdina naozaj vyhrá?
// 
//*

class Hrdina
{
    public string Meno = "";
    public int Zdravie = 100;
    public int Energia = 50;


    public int PrijmiZranenie(int sila)
    {
        Zdravie = Zdravie - sila;
        if (Zdravie < 0)
        {
            Zdravie = 0;
        }

        return Zdravie;
    }
public Boolean Utok(int cenautoku)
    {
        if (Energia < cenautoku)
        {
            return false;
        }
        else
        {
            Energia = Energia - cenautoku;
            return true;
        }
    }

    public void VypisAktualnystav()
    {
        Console.WriteLine("Meno: "+Meno);
        Console.WriteLine("Zdravie: "+Zdravie);
        Console.WriteLine("Energia: "+Energia);
    }
    
}

class Ucet
{
    public string cislo = "";
    public int zostatok = 0;
    public string majitel = "";

    public int VlozPeniaze(int suma)

    {
        if (suma < 0)
        {
            return zostatok;
        }
        else
        {
            zostatok = zostatok + suma;
            return zostatok;

        }
    }

    public bool VyberPeniaze(int suma)
    {
        if (suma > zostatok || suma < 0)
        {
            return false;
        }
        else
        {
            zostatok = zostatok - suma;
            return true;
        }
    }

    public bool PosliPeniaze(int suma, Ucet cielovy_ucet)
    {
        if (suma <= 0)
        {
            return false;
        }

        bool podarilsaVyber = VyberPeniaze(suma);

        if (podarilsaVyber)
        {
            cielovy_ucet.VlozPeniaze(suma);
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Datum
        {
            public int Den;
            public int Mesiac;
            public int Rok;
            public void Porovnaj(Datum druhyDatum)
            {
                if (Rok < druhyDatum.Rok)
                {
                    Console.WriteLine("Prvy datum je skor");
                }
                else if (Rok > druhyDatum.Rok)
                {
                    Console.WriteLine("Druhy datum je skor");
                }
                else if (Mesiac < druhyDatum.Mesiac)
                {
                    Console.WriteLine("Prvy datum je skor");
                }
                else if (Mesiac > druhyDatum.Mesiac)
                {
                    Console.WriteLine("Druhy datum je skor");
                }
                else if (Den < druhyDatum.Den)
                {
                    Console.WriteLine("Prvy datum je skor");
                }
                else if (Den > druhyDatum.Den)
                {
                    Console.WriteLine("Druhy datum je skor");
                }
                else
                {
                    Console.WriteLine("Datumy su rovnake");
                }
            }
        }
        
    
