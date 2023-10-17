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
        
        if (filePath.StartsWith("~"))
        {
            var absoluterPfad = filePath.Replace("~", nutzerVerzeichnis);
            
            return absoluterPfad;

        }

        if (filePath.StartsWith("."))
        {
            var projektVerzeichnis = Path.Combine(nutzerVerzeichnis, "RiderProjects/MakePathAbsoluteAgain/MakePathAbsoluteAgain/");
            
            
            var absoluterPfad = filePath.Replace("./", projektVerzeichnis);
            

            return absoluterPfad;
        }

        return filePath;

    }
    
    
}