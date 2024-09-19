namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programmer:  Rasmus Wenngren
            // Program:     Fullstack .NET 2024
            // Course:      Programmering med C# och .NET
            // Lab 1:       MyFirstProgram

            int number = 11; // variabel som lagrar data
                if (number > 10) // påstående som ska uppfyllas för att koden under ska köras
                {
                    Console.WriteLine("Talet är stort!");//Meddelande som skrivs ut om talet är för stort
                    
                }
                else // kodstycke som körs om den inmatade datan inte uppfyller första påståendet
                {
                    Console.WriteLine("Oj. Lågt Tal!");//Meddelande som skrivs ut om talet är för litet
                   
                }
            {
                Console.WriteLine("Vad heter du?");
                
                string name = Console.ReadLine();//deklarerar värde av name direkt med vad användaren skriver in
                Console.WriteLine("Hej " + name);//skriver ut ett meddelande till användaren
               
            }
            {
                int i = 0; //grundvärdet sätts till 0

                while (i <= 11)//så länge värdet är mindre eller lika med 11 så kommer loopen fortsätta
                {
                    Console.WriteLine(i);//skriver ut från siffra noll och uppåt
                    i++;
                }
                Console.Read();//För att hinna se vad som står ligger det en Read här vilket tvingar användaren att trycka på valfri tangent för att gå vidare
            }
        }
    }
}
