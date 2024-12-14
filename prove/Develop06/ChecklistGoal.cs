public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int currentCount, int bonusPoints)
        : base(name, points)
    {
        this.targetCount = targetCount;
        this.currentCount = currentCount;
        this.bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            if (currentCount == targetCount)
            {
                return Points + bonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override string GetDetails()
    {
        return $"[ {(currentCount >= targetCount ? "X" : " ")} ] {Name} (Completed {currentCount}/{targetCount}, Points: {Points}, Bonus: {bonusPoints})";
    }

    public override string Serialize()
    {
        return base.Serialize() + $"|{targetCount}|{currentCount}|{bonusPoints}";
    }

    public static new ChecklistGoal Deserialize(string data)
    {
        var parts = data.Split('|');
        return new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
    }
}
