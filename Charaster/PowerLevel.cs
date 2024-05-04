namespace Charaster
{
    public class Level
    {
        enum LevelType
        {
            Feeble,
            Average,
            Competent,
            Exceptional,
            Heroic,
            LargerThanLife,
            Legendary,
            Superhuman,
            Godlike
        }

        public int Points { get; set;}

        LevelType Type => Points switch
            {
                <= 25 => LevelType.Feeble,
                > 25 and <= 50 => LevelType.Average,
                > 50 and <= 75 => LevelType.Competent,
                > 75 and <= 100 => LevelType.Exceptional,
                > 100 and <= 200 => LevelType.Heroic,
                > 200 and <= 300 => LevelType.LargerThanLife,
                > 300 and <= 500 => LevelType.Legendary,
                > 500 and <= 1000 => LevelType.Superhuman,
                > 1000 => LevelType.Godlike,
                _ => throw new Exception()
            };
    }
}