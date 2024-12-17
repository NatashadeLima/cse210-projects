using System;
using System.Collections.Generic;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public int DurationInMinutes { get; set; }

    public Activity(DateTime date, int durationInMinutes)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {this.GetType().Name} ({DurationInMinutes} min): Distance {GetDistance():0.0} " +
               (this is Running ? "miles" : "km") + $", Speed: {GetSpeed():0.0} " + 
               (this is Running || this is Cycling ? "mph" : "kph") + $", Pace: {GetPace():0.0} min per " + 
               (this is Running ? "mile" : "km");
    }
}