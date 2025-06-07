using System;
using System.IO;

namespace Workspace;

public class ProcessFile
{
    public static void Main()
    {
        FileStream fs = null;

        try
        {
            fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (fs != null)
            {
                fs.Close();
            }
        }
    }
}
