namespace LegacyLibrary;

public interface IPdfGenerator
{
    public void CreatePage(File file);

    public void DrawIntoPage(File file);

    public void ChangeColor(File file);

    public void Render(File file);
}