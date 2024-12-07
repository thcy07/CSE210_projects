using System;
using System.Runtime.InteropServices;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List <Comment> comments = new List<Comment>
        {
            new Comment("crazyChIkEn", "Yoooo this helped!! Love it "),
            new Comment("stargazingVoid", "Christmas is coming."),
            new Comment("UltimateG", "Amazing!!!!")
        };
        
       List<Comment> comments1 = new List<Comment>
        {
            new Comment("codingWhiz123", "This is so helpful!"),
            new Comment("natureFanatic", "Great advice, thanks!"),
            new Comment("lateNightOwl", "Needed this today.")
        };

        List<Comment> comments2 = new List<Comment>
        {
            new Comment("travelBug98", "Super useful tips!"),
            new Comment("minimalistLife", "Love the simplicity here."),
            new Comment("studyHacker", "Game changer for sure.")
        };

        List <Video> videos = new List<Video>
        {
            new Video( "How to make it through Finals", "damselINdistress", 90, comments),
            new Video("Top 5 Study Hacks", "learnWithMe", 120, comments1),
            new Video("Travel Essentials", "roamFreeVlogs", 180, comments2)
        };

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}