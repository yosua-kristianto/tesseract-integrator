using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tesseract;
using tesseract_integrator.Src.Main.Messaging;
using tesseract_integrator.Src.Main.Messaging.Consumer;

class Program
{
    private void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<BaseMessaging, OCRProcessorConsumer>();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(AppContext.BaseDirectory);

        string imagePath = "D:\\Code\\College\\Thesis Research\\CRNN Experiments\\thesis-thingy\\Src\\Resources\\Image\\2.png";
        string tesseractFeederPath = "D:\\Code\\College\\Thesis Research\\CRNN Experiments\\thesis-thingy\\Src\\Resources\\Data\\";

        TesseractEngine model = new TesseractEngine(tesseractFeederPath, "eng", EngineMode.Default);
        Pix loadedImage = Pix.LoadFromFile(imagePath);

        Page page = model.Process(loadedImage);

        string text = page.GetText();

        Console.WriteLine("Detected Text: " + text);
    }
}