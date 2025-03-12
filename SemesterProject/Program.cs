namespace SemesterProject;

public static class Program
{
    public static void Main()
    {
        Random rand = new Random();
        int X = 500;
        int Y = 500;
        int W = 400;
        int H = 200;
        var svg = new SvgBuilder(500, 500)
        .AddRectangle(rand.Next(X) , rand.Next(Y), rand.Next(W), rand.Next(H), "#FF0000")
        .AddRectangle(rand.Next(X) , rand.Next(Y), rand.Next(W), rand.Next(H), "#00FF00")
        .AddRectangle(rand.Next(X) , rand.Next(Y), rand.Next(W), rand.Next(H), "#0000FF")
        .Build();

        Console.Write("Absolute path to save SVG at: ");
        var path = Console.ReadLine() ?? "";
        using var streamWriter = new StreamWriter(path);

        streamWriter.WriteLine(svg);
    }



}
