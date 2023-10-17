static int[] RandomArray()
    {
        int[] randomNumbers = new int[10];
        Random random = new Random();

        for (int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = random.Next(5, 26);
        }

        int minValue = randomNumbers.Min();
        int maxValue = randomNumbers.Max();
        int sum = randomNumbers.Sum();

        Console.WriteLine("Valores mínimos: " + minValue);
        Console.WriteLine("Valores máximos: " + maxValue);
        Console.WriteLine("Suma de todos los valores: " + sum);

        return randomNumbers;
    }

    static string TossCoin()
    {
        Random random = new Random();
        int result = random.Next(2); // 0 para Cara, 1 para Cruz

        Console.WriteLine("¡Tirando una moneda!");
        if (result == 0)
        {
            Console.WriteLine("Cara");
            return "Cara";
        }
        else
        {
            Console.WriteLine("Cruz");
            return "Cruz";
        }
    }

    static double TossMultipleCoins(int num)
    {
        int heads = 0;
        for (int i = 0; i < num; i++)
        {
            if (TossCoin() == "Cara")
            {
                heads++;
            }
        }
        return (double)heads / num;
    }

    static List<string> Nombres()
    {
        List<string> names = new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };
        List<string> filteredNames = names.Where(name => name.Length > 5).ToList();

        // Opcional: Barajar la lista
        Random random = new Random();
        filteredNames = filteredNames.OrderBy(x => random.Next()).ToList();

        return filteredNames;
    }


        int[] randomNumbers = RandomArray();
        string coinResult = TossCoin();
        Console.WriteLine("Resultado del lanzamiento de moneda: " + coinResult);
        double headRatio = TossMultipleCoins(10);
        Console.WriteLine("Proporción de caras: " + headRatio);
        List<string> filteredNames = Nombres();
        Console.WriteLine("Nombres con más de 5 caracteres:");
        foreach (string name in filteredNames)
        {
            Console.WriteLine(name);
        }
    