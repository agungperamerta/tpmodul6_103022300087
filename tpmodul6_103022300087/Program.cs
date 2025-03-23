using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title))
            throw new ArgumentException("Title cannot be null or empty");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0)
            throw new ArgumentException("Play count cannot be negative");

        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("----------Video Details----------");
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – AGUNG PERAMERTA");
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();
    }
}