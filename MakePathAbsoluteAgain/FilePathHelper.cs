namespace MakePathAbsoluteAgain;

public class FilePathHelper
{
    public static string MakeAbsolute(string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath))
        {
            return filePath;
        }
        
        var nutzerVerzeichnis = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        var projektVerzeichnis = Path.Combine(nutzerVerzeichnis, "RiderProjects/MakePathAbsoluteAgain/MakePathAbsoluteAgain/");
        
        if (filePath.StartsWith("~"))
        {
            var absoluterPfad = filePath.Replace("~", nutzerVerzeichnis);
            
            return absoluterPfad;

        }

        if (filePath.StartsWith("."))
        {
            var absoluterPfad = filePath.Replace("./", projektVerzeichnis);
            

            return absoluterPfad;
        }

        if (filePath.Contains(".."))
        {
            string[] pfadTeile = filePath.Split(Path.DirectorySeparatorChar);
            var bereinigtePfadTeile = new List<string>();

            foreach (var part in pfadTeile)
            {
                if (part == ".." && bereinigtePfadTeile.Count > 0)
                {
                    bereinigtePfadTeile.RemoveAt(bereinigtePfadTeile.Count - 1);
                }
                else if (part != "." && part != "..")
                {
                    bereinigtePfadTeile.Add(part);
                }
            }
            
            string absoluterPfad = string.Join(Path.DirectorySeparatorChar, bereinigtePfadTeile);


            return absoluterPfad;
        }
        
        return filePath;

    }
    
    
}