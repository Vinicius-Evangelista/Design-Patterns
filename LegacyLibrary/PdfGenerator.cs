namespace LegacyLibrary;

public class PdfGenerator : IPdfGenerator
{
    public void ChangeColor(File file)
    {
        Console.WriteLine("Color Changed");
    }

    public void CreatePage(File file)
    {
        Console.WriteLine("Page Created");
    }

    public void DrawIntoPage(File file)
    {
        Console.WriteLine("Drawed");
    }

    public void Render(File file)
    {
        Console.WriteLine("Rendered");
    }
}
