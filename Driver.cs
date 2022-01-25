using System;

public class Driver
{
    public string firstName, lastName, shortName;

    public Driver(string first, string last)
	{
        firstName = first;
        lastName = last;

        shortName = lastName.Substring(0, 3).ToUpper();
	}

}
