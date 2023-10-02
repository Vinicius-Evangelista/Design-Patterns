namespace LegacyLibrary;


// Client Class
public class GeneratePdf
{
    private readonly IPdfGenerator _pdfGenerator;


    public GeneratePdf(IPdfGenerator pdfGenerator)
    {
        _pdfGenerator = pdfGenerator;
    }


    public void CreatePdf(Pdf pdf)
    {
        _pdfGenerator.CreatePage(pdf);
        _pdfGenerator.DrawIntoPage(pdf);
        _pdfGenerator.ChangeColor(pdf);
        _pdfGenerator.Render(pdf);
    }
}