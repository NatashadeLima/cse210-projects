
using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2015;
        job1._endYear = 2020;

        // Console.WriteLine(job1._company);

        // job1.DisplayJobDetails();

        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Senior Developer";
        job2._startYear = 2020;
        job2._endYear = 2023;

        // Console.WriteLine(job2._company);

        // job2.DisplayJobDetails();

        Resume infoResume = new Resume();
        infoResume._name = "João Amaral";

        infoResume._jobs.Add(job1);
        infoResume._jobs.Add(job2);

        //Console.WriteLine(infoResume._jobs[0]._jobTitle);

        infoResume.DisplayJobDetails();

    }


}
