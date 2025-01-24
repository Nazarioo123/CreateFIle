using System.Security.Authentication;
using System.IO;
using System.Text;

namespace CreateFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string directoryPath = @"c:\HomeTask2";
            string filePath = Path.Combine(directoryPath,"MyText.txt");

            if (File.Exists(filePath))
            {
                Directory.CreateDirectory(directoryPath);
                
            }

            Console.WriteLine("введіть текст");  
            string txt = Console.ReadLine();

            try
            {
                File.WriteAllText(filePath, txt);
            }
            catch (Exception ex)
            { Console.WriteLine("помилкка"); }

            File.WriteAllText("MyText.txt", txt);
            Console.WriteLine("ваш текст записано ");

           
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("змістФайлу : ");
            Console.WriteLine(fileContent);
            
            
            
         





          
        }
    }
}
