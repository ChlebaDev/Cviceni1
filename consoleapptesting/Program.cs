bool success;
int optionSelect;

    while (true)
    { 

        Console.WriteLine("Jakou metodu řad chceš použít?\n\n[0] - Ukončit\n[1] - Aritmetická posloupnost (začátek, krok, počet prvků)\n[2] - Aritmetická posloupnost (začátek, konec, krok)\n[3] - Geometrická posloupnost (začátek, konec, počet prvků)");
        string? input = Console.ReadLine();
        success = int.TryParse(input, out optionSelect);

        if (optionSelect == 0)
        {
            Console.WriteLine("\nKONEC PROGRAMU\n");
            break;
        }

        if (optionSelect == 1)
        {
            bool result;

            Console.WriteLine("Jaký chceš začínající prvek? ");
            string? start = Console.ReadLine();
            result = int.TryParse(start, out int startingNum);

            Console.WriteLine("Jak velký chceš krok? ");
            string? step = Console.ReadLine();
            result = int.TryParse(step, out int stepLength);

            Console.WriteLine("Kolik chceš vygenerovat čísel? ");
            string? quantity = Console.ReadLine();
            result = int.TryParse(quantity, out int numQuantity);

            for (int i = 0; i < numQuantity; i++)
            {
                Console.Write($" \n{startingNum} ");
                startingNum += stepLength;
            }
            break;
        }

        else if (optionSelect == 2)
        {
            bool result;

            Console.WriteLine("Jakým číslem chceš začít? ");
            string? start = Console.ReadLine();
            result = int.TryParse(start, out int startingNum);

            Console.WriteLine("Jakým číslem chceš končit? ");
            string? end = Console.ReadLine();
            result = int.TryParse(end, out int endingNum);

            Console.WriteLine("O kolik chceš přičítat? ");
            string? step = Console.ReadLine();
            result = int.TryParse(step, out int stepLength);

            if ((startingNum <= 0 && endingNum >= 0 && stepLength <= 0) || (startingNum >= 0 && endingNum <= 0 && stepLength >= 0) || ((startingNum <= 0 && startingNum >= endingNum) && stepLength >= 0) || ((startingNum >= 0 && startingNum <= endingNum) && stepLength <= 0))
            {
                Console.WriteLine("\n ERROR - CALCULATEN'T \n");
            }
      else if (stepLength >= 0)
            {
                while (startingNum <= endingNum)
                {
                    Console.Write($" \n{startingNum}");
                    startingNum += stepLength;
                }
            }
            else
                while (startingNum >= endingNum)
                {
                    Console.Write($" \n{startingNum}");
                    startingNum += stepLength;
                }
            break;
        }

        else if (optionSelect == 3)
        {
            
            bool result;

            Console.WriteLine("Jakým číslem chceš začít? ");
            string? start = Console.ReadLine();
            result = int.TryParse(start, out int startingNum);

            Console.WriteLine("Jakým číslem chceš násobit? ");
            string? step = Console.ReadLine();
            result = int.TryParse(step, out int stepLength);

            Console.WriteLine("Kolik chceš vygenerovat čísel? ");
            string? quantity = Console.ReadLine();
            result = int.TryParse(quantity, out int numQuantity);

            for (int i = 0; i < numQuantity; i++)
            {
                Console.Write($" \n{startingNum} ");
                startingNum *= stepLength;

            }
            break;
        }
    
}
