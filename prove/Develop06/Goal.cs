
public abstract class Goal
{
    public string Name { get; private set; }
    public int Points { get; private set; }

    protected Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract string GetDetails();

    public virtual string Serialize()
    {
        return $"{GetType().Name}|{Name}|{Points}";
    }

    public static Goal Deserialize(string data)
    {
        var parts = data.Split('|');
        string type = parts[0];
        string name = parts[1];
        int points = int.Parse(parts[2]);

        switch (type)
        {
            case "SimpleGoal":
                return new SimpleGoal(name, points);
            case "EternalGoal":
                return new EternalGoal(name, points);
            case "ChecklistGoal":
                int targetCount = int.Parse(parts[3]);
                int currentCount = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                return new ChecklistGoal(name, points, targetCount, currentCount, bonus);
            default:
                return null;
        }
    }
}
