using System.IO;

string path = @"C:\Users\eloch\Downloads\theMachineStops.txt";

FileInfo newFile = new FileInfo(path);


using (StreamWriter writer = newFile.CreateText())
{
    writer.WriteLine("Hello world!");
    
}

string line = " ";

try
{
    using (StreamReader reader = newFile.OpenText())
    {

        line = reader.ReadLine();

        while (!String.IsNullOrWhiteSpace(line))
        {
            line = reader.ReadLine();
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}