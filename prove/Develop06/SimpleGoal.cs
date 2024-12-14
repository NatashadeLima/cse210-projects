
public class SimpleGoal : Goal
{
    private bool isCompleted;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        isCompleted = false;
    }

    public override int RecordEvent()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            return Points;
        }
        return 0;
    }

    public override string GetDetails()
    {
        return $"[ {(isCompleted ? "X" : " ")} ] {Name} (Points: {Points})";
    }

    public override string Serialize()
    {
        return base.Serialize() + $"|{isCompleted}";
    }

    public static new SimpleGoal Deserialize(string data)
    {
        var parts = data.Split('|');
        var goal = new SimpleGoal(parts[1], int.Parse(parts[2]));
        goal.isCompleted = bool.Parse(parts[3]);
        return goal;
    }
}
