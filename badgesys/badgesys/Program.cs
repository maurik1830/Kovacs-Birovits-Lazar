class KituntetesRendszer
{
    private const string feladatokFajl = "feladatok.txt";
    private const string kituntetesekFajl = "kituntetesek.txt";
    private const string haladasFajl = "haladas.txt";
    private const int pontokFeladatonkent = 10;

    private List<string> elvegzettFeladatok = new List<string>();
    private List<string> kituntetesek = new List<string>();
    private int pontok = 0;

    public void HaladasBetoltese()
    {
        if (File.Exists(haladasFajl))
        {
            string[] sorok = File.ReadAllLines(haladasFajl);
            foreach (string sor in sorok)
            {
                string[] reszek = sor.Split(':');
                string feladat = reszek[0];
                bool elvegzett = bool.Parse(reszek[1]);
                if (elvegzett)
                {
                    elvegzettFeladatok.Add(feladat);
                }
            }
        }
    }

    public void HaladasMentese()
    {
        using (StreamWriter iras = new StreamWriter(haladasFajl, false))
        {
            foreach (var feladat in elvegzettFeladatok)
            {
                iras.WriteLine($"{feladat}:true");
            }
        }
    }

    public void FeladatokBetoltese()
    {
        if (File.Exists(feladatokFajl))
        {
            string[] feladatok = File.ReadAllLines(feladatokFajl);
            foreach (string feladat in feladatok)
            {
                if (!elvegzettFeladatok.Contains(feladat))
                {
                    elvegzettFeladatok.Add(feladat);
                }
            }
        }
    }



    public void KituntetesekBetoltese()
    {
        if (File.Exists(kituntetesekFajl))
        {
            string[] kituntetesek = File.ReadAllLines(kituntetesekFajl);
            this.kituntetesek.AddRange(kituntetesek);
        }
    }

    public void FeladatTeljesitese(string feladat)
    {
        if (elvegzettFeladatok.Contains(feladat))
        {
            Console.WriteLine($"A feladat már teljesítve van: {feladat}");
        }
        else
        {
            elvegzettFeladatok.Add(feladat);
            pontok += pontokFeladatonkent; // Pontok növelése
            Console.WriteLine($"Feladat teljesítve: {feladat}");
        }
    }


    public void KituntetesekMutatasa()
    {
        Console.WriteLine("Elért kitüntetések:");
        foreach (string kituntetes in kituntetesek)
        {
            Console.WriteLine(kituntetes);
        }
    }

    public void PontokMutatasa()
    {
        Console.WriteLine($"Jelenlegi pontok: {pontok}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        KituntetesRendszer kituntetesRendszer = new KituntetesRendszer();
        kituntetesRendszer.FeladatokBetoltese();
        kituntetesRendszer.KituntetesekBetoltese();
        kituntetesRendszer.HaladasBetoltese();

        // Feladatok teljesítése
        kituntetesRendszer.FeladatTeljesitese("10 játékmenet teljesítve");
        kituntetesRendszer.FeladatTeljesitese("100 arany összegyűjtve");

        kituntetesRendszer.HaladasMentese();
        kituntetesRendszer.KituntetesekMutatasa();
        kituntetesRendszer.PontokMutatasa();
    }
}