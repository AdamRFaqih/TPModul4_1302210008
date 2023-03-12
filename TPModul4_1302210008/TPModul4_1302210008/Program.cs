class Utama
{
    public static void Main()
    {

        Console.WriteLine("Implementasi Soal Table-Driven");
        KodePos kodePos = new KodePos();
        kodePos.getKodePos();
        Console.WriteLine();

        Console.WriteLine("Implementasi Soal State Based Construction");
        DoorMachine doorMachine = new DoorMachine();
        doorMachine.DoorMachineStart();

    }

}

class KodePos
{
    struct tabel
    {
        public string kelurahan;
        public string kodePos;

    }

    tabel[] tabelKodePos = new tabel[]
    {
        new tabel{ kelurahan ="Batununggal",kodePos="40266"},
        new tabel{ kelurahan ="Kujangsari",kodePos="40287"},
        new tabel{ kelurahan ="Mengger",kodePos="40267"},
        new tabel{ kelurahan ="Wates",kodePos="40256"},
        new tabel{ kelurahan ="Cijaura",kodePos="40287"},
        new tabel{ kelurahan ="Jatisari",kodePos="40286"},
        new tabel{ kelurahan ="Margasari",kodePos="40286"},
        new tabel{ kelurahan ="Sekejati",kodePos="40286"},
        new tabel{ kelurahan ="Kebonwaru",kodePos="40272"},
        new tabel{ kelurahan ="Maleer",kodePos="40274"},
        new tabel{ kelurahan ="Samoja",kodePos="40273"}
    };

    public void getKodePos()
    {
        for (int i = 0; i < tabelKodePos.Length; i++)
        {
            Console.WriteLine(tabelKodePos[i].kelurahan + ": " + tabelKodePos[i].kodePos);
        }
    }
}

class DoorMachine
{
    enum State {Terkunci, Terbuka };
    public void DoorMachineStart()
    {
        State state = State.Terkunci;
        string command;
        string[] screenName = { "Terkunci", "Terbuka" };
        Console.WriteLine("Pintu " + screenName[(int)state]);
        Console.Write("Masukan Command: ");
        command = Console.ReadLine();
        while (command != "exit")
        {
            switch (state)
            {
                case State.Terbuka:
                    if (command == "KunciPintu")
                        state = State.Terkunci;
                    else if (command == "BukaPintu")
                        state = State.Terbuka;
                    else
                        state = State.Terbuka;
                break;
                case State.Terkunci:
                    if (command == "KunciPintu")
                        state = State.Terkunci;
                    else if (command == "BukaPintu")
                        state = State.Terbuka;
                    else
                        state = State.Terkunci;
                break;
            }
            Console.WriteLine("Pintu " + screenName[(int)state]);
            Console.Write("Masukan Command: ");
            command = Console.ReadLine();
        }
        Console.WriteLine("Keluar Pintu");
    } 
}

