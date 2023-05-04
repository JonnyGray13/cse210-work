using System;

public class Job
{
    public string _jobTitle;
    public string _companyName;
    public int _firstYear;
    public int _lastYear;
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_firstYear}-{_lastYear}");
    }
}