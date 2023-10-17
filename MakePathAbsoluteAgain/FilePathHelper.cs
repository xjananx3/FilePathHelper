namespace MakePathAbsoluteAgain;

public class FilePathHelper
{
    public static string MakeAbsolute(string filePath)
    {
        
        var nutzerVerzeichnis = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);


        if (filePath.StartsWith("~"))
        {
            var absoluterPfad = filePath.Replace("~", nutzerVerzeichnis);

            
            return absoluterPfad;

        }


        return filePath;

    }
    
    
}