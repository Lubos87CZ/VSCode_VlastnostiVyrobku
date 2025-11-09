using VlastnostiVyrobku;

        string nazevVyrobku;
        string popisVyrobku;
        double hmotnostVyrobku;
        char odpoved;
        bool opakovat = true;
        Vyrobek vyrobek;

        Console.WriteLine("Program Vlastnosti vyrobku\n");
        Console.WriteLine("==========================");
        do
        {
            Console.WriteLine("Zadejte nazev vyrobku: ");
            nazevVyrobku = Console.ReadLine();
            Console.WriteLine("Zadejte popis vyrobku: ");
            popisVyrobku = Console.ReadLine();
            Console.WriteLine("Zadejte hmotnost vyrobku: ");
            while (!Double.TryParse(Console.ReadLine(), out hmotnostVyrobku))
                Console.WriteLine("Spatne zadani! Opakujte!");
            Console.WriteLine("--------------------------\n");
            vyrobek = new Vyrobek(nazevVyrobku, popisVyrobku, hmotnostVyrobku);
            Console.WriteLine(vyrobek.VypisVyrobek());
            Console.WriteLine();
            Console.WriteLine("--------------------------\n");
            Console.Write("Chcete upravit vyrobek (a/n)?");
            odpoved = Console.ReadKey().KeyChar;
            if (odpoved == 'a')
            {
                Console.WriteLine("\nZadejte nazev vyrobku: ");
                nazevVyrobku = Console.ReadLine();
                Console.WriteLine("Zadejte popis vyrobku: ");
                popisVyrobku = Console.ReadLine();
                Console.WriteLine("Zadejte hmotnost vyrobku: ");
                while (!Double.TryParse(Console.ReadLine(), out hmotnostVyrobku))
                    Console.WriteLine("Spatne zadani! Opakujte!");
                vyrobek.EditujVyrobek(nazevVyrobku, popisVyrobku, hmotnostVyrobku);
                Console.WriteLine();
                Console.WriteLine(vyrobek.VypisVyrobek());
            }
            else
                Console.WriteLine();

            Console.Write("Chcete opakovat zadani (a/n)?");
            odpoved = Console.ReadKey().KeyChar;
            if (odpoved == 'a')
                opakovat = true;
            else
                opakovat = false;
            Console.WriteLine();
        } while (opakovat);
        Console.WriteLine("Dekujeme za pouziti programu.");
        Console.ReadLine();