using CaeserCipherAlgorithm;

public class Program{
    public static void Main()
    {
        try
        {
            Console.Write("Enter text:");
            string inputString = Console.ReadLine();
            Console.Write("Enter Shifting factor:");
            int shiftingFactor = int.Parse(Console.ReadLine());
            CaeserCipher ceaserCipher = new CaeserCipher();

            string cipheredText = ceaserCipher.DoCeaserCipher(inputString, shiftingFactor);
            Console.WriteLine("Ciphered Text:" + cipheredText);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
        catch (NullReferenceException ex1)
        {
            Console.WriteLine(ex1.Message);
            Console.WriteLine();
        }

    }
}
