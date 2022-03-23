namespace Kalakulator;

public class Kalkulator
{

    public static int SplitAndParseString(string[] oo)
    {
        int a;
        int b;
        int rez;
        a = Int32.Parse(oo[0]);
        b = Int32.Parse(oo[2]);
        switch (oo[1])
        {
            case "+": rez = a + b;
                break;
            case "-": rez = a - b;
                break;
            case "*": rez = a * b;
                break;
            case "/": rez = a / b;
                break;
            default: rez = -1000000;
                break;
        }

        return rez;
    }
    
    public static void Main()
    {
        string test;
        
        Console.Write("\n\nKalkulator\n");
        Console.Write("---------------------\n");   
        
        while (true)
        {
            Console.Write("Unesite izraz: ");
            test = Console.ReadLine() ?? throw new InvalidOperationException();

            if (test == "exit" || test == "kraj")
            {
                break;
            }
            else
            {
                string[] operandsOperations = test.Split(" ");
                if (operandsOperations.Length == 3)
                {
                    int rez = SplitAndParseString(operandsOperations);
                    Console.Write("Rezultat je: " + rez + "\n");
                }
                else
                {
                    Console.Write("Neispravan unos! Imate previse parametara");
                }
            }
            
            
        }
            
        
    }
}