using static System.Console;
namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory
            var greeingMessage = new Dictionary<string, string>()
            {
                { "abc","HI.." },
                { "xyz","Bye.." }
                
            };

            greeingMessage["xyz"] = "Thank you";

            foreach (var key in greeingMessage.Keys)
            {
                Console.WriteLine($"Key: {key}");
            }

            foreach (var value in greeingMessage.Values)
            {
                Console.WriteLine($"Value: {value}");
            }

            foreach (var message in greeingMessage)
            {
                Console.WriteLine($"Key: {message.Key} Value: {message.Value}");
            }
            //Exceptions
            try
            {
                WriteLine("Please enter the intiger number ");
                int num1 = int.Parse(Console.ReadLine());
                int num2= int.Parse(Console.ReadLine());

                int result = num1 / num2;
                WriteLine(result);

            }
            catch (DivideByZeroException ex)
            {
                WriteLine(ex.ToString());
            }
            catch (FormatException ex)
            {
                WriteLine(ex.ToString());
            }
            catch (OverflowException ex)
            {
                WriteLine($"Your number should be between {int.MinValue} and {int.MaxValue}");

            }
            catch (Exception ex) 
            { 
                WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Finally block is called");
            }
            ReadKey();
        }
    }
}
