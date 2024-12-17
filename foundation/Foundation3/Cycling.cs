using System;
using System.Collections.Generic;

public class Cycling : Activity
{
    public double SpeedInMph { get; set; }

    public Cycling(DateTime date, int durationInMinutes, double speedInMph)
        : base(date, durationInMinutes)
    {
        SpeedInMph = speedInMph;
    }

    public override double GetDistance()
    {
        return (SpeedInMph * DurationInMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return SpeedInMph;
    }

    public override double GetPace()
    {
        return 60 / SpeedInMph;
    }
}