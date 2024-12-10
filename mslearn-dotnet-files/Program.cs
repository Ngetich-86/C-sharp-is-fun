using System.IO;
using System.Collections.Generic;


IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();
    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);
    foreach (var file in foundFiles)
    {
        if (file.EndsWith("sales.json"))
        {
            salesFiles.Add(file);
        }
    }
    return salesFiles;
}


var salesFiles = FindFiles("stores");
foreach(var file in salesFiles){
    Console.WriteLine(file);
   

}
Console.WriteLine(Directory.GetCurrentDirectory());
Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
Console.WriteLine(Path.Combine("stores","201")); // outputs: stores/201
Console.WriteLine(Path.GetExtension("sales.json")); // outputs: .json