using ConsoleApp1;
using System.Runtime.Serialization.Formatters;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
      
        while (true)
        {
            var Task = new TasksSelector();
            Task.sealectTask();
            

            Console.ReadLine();
            
        }
    }

 
}
       