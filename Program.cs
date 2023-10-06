namespace CSharpLucky
{
    public class Game
    {

        public static void Main(string[] args)
        {
            Random r = new Random();

            int num = r.Next(100);
            int tryes = 0;
            int hintCount = 0;
            int hintDifference = r.Next(0,50);
            
            do
            {
                try {
                    Console.Write("\nInsert a number between 0 and 100: ");
                    int choice = int.Parse(Console.ReadLine()!);
                    tryes++;
                    hintCount++;
                    

                    if (choice != num)
                    {
                        Console.WriteLine("Your choice is have little distance of the number.");
                        Console.WriteLine("Again, dont breakup!\n");
                        
                        if (hintCount >= 5) 
                        {
                            Console.Clear();
                            Console.WriteLine("Bip, Bop! I clear the outputs!");
                            Console.WriteLine($"If u tired, just take a hint: The number is between {num - hintDifference} and {num + hintDifference}!");
                            hintCount = 0;
                            hintDifference = r.Next(0,50);
                        }
                    }
                    else
                    {

                        string res = tryes < 10 ? "Too Good Bro!" : "Too Bad, damn!";
                        Console.WriteLine($"Yeah Baby, you win after {tryes} tryes!\n");
                        tryes = 0;
                        num = r.Next(100);
                    }
                } catch (Exception e) { Console.WriteLine("Something is wrong, try again please!" + $"({e})"); }
                
            } while (true);

        }

    }

}
