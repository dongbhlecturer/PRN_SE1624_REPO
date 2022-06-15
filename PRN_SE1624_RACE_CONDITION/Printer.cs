namespace Prn.Threading;
public class Printer
{
    private object _lock = new object();
    public void PrintNumber()
    {
        lock(_lock)
            try
            {
                //Display thread-info
                Console.WriteLine($"{Thread.CurrentThread.Name} is executing PrintNumber()");
                //print out numbers
                for (int i = 1; i <= 5; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(500 * r.Next(5));
                    Console.Write($"{i,3}{(i == 5 ? "" : ",")}");
                }
                Console.WriteLine();   //break line 
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //nothing variables and cursor...
            }
        
       
    }
}