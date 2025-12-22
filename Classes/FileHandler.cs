using System.Linq.Expressions;

public class FileHandler : IFileHander
{
    public void AppendFileContent(string? filePath, string? content)
    {
        try
        {

        }
        catch
        {
            throw new FileNotFoundException();
        }
    }

    //! actual logic to be used in Program.cs should be made here
    //! before being called on in Program.cs
    public void ReadFileContent(string? filePath)
    {
        try
        {
            var readContent = File.ReadAllText(filePath);

        }
        catch
        {
            throw new FileLoadException();
        }
    }
}
