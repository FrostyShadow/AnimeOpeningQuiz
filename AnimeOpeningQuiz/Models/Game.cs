using System.Collections.Generic;

namespace AnimeOpeningQuiz.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string GameTitle { get; set; }
        public int QuestionCount { get; set; }
        public int DifficultyLevelCount { get; set; }
        public int QuestionCountPerDifficulty { get; set; }
        public long RoomCode { get; set; }
        public virtual List<Player> Players { get; set; }
    }
}