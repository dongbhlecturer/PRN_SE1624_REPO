using System;
using System.Threading;
namespace Prn.Threading;
  
public class Program
{
    public static void Main()
    {
            Printer p = new Printer();
            Thread[] tr = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                tr[i] = new Thread(()=>p.PrintNumber());
                tr[i].Name = String.Format("Working Thread: {0}", i);
            }
            //Start each thread  
            foreach (Thread x in tr)
            {
                x.Start();
            }
            Console.ReadKey();
        
    }
}

