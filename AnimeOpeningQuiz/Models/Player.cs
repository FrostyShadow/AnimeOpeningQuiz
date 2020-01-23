namespace AnimeOpeningQuiz.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int OverallScore { get; set; }
        public int ScorePerLevel { get; set; }
        public int GameId { get; set; }
        public virtual Game Game { get; set; }
    }
}