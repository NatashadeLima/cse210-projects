public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetDetails()
    {
        return $"[ ] {Name} (Points per occurrence: {Points})";
    }
}
