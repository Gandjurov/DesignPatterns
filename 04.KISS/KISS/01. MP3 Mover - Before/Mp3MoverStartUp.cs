using KISSMp3MoverBefore.Factories;
using System;

namespace KISSMp3MoverBefore
{
    public class Mp3MoverStartUp
    {
        public static void Main(string[] args)
        {
            var mp3Mover = Mp3Mover.Instance;
            mp3Mover.DirectoryPath = @"C:\MyMusic\";
            mp3Mover.SelectStrategy = new FileSelectStrategyFactory().Get("ArtistDashSong");
            mp3Mover.RenameStrategy = new FileRenameStrategyFactory().Get("RemoveArtist");
            mp3Mover.MoveStrategy = new FileMoveStrategyFactory().Get("Normal");
            mp3Mover.Start();
        }
    }
}
