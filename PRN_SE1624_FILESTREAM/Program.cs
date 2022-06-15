using System.IO;
using System.Text;
namespace Prn.FileStreamDemo;

public class Program
{
    public static void Main()
    {
        //1. khoi tao contents
        string msg = "ABCDEF123";
        //2. Convert msg => byte array - 1D
        byte[] msgBytes = Encoding.UTF8.GetBytes(msg);
        //3. dung FileStream de mo 1 file
        try
        {
            using FileStream fileStream = File.Open(@"d:\demo\data.dat", FileMode.Create);
            //4. save msgBytes => file data.dat
            fileStream.Write(msgBytes, 0, msgBytes.Length);
            fileStream.Position = 0;
            fileStream.Close();
        } catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
       
        
        Console.WriteLine("finished...");
        Console.ReadLine();
        
        /*************Read File*********************/


    }
}