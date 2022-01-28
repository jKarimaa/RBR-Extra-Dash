using System;
using System.Collections.Generic;

public class Driver
{
    public string firstName, lastName, shortName;
    public List<string> stageResults;

    public Driver(string fullName)
	{
        string[] splitName = fullName.Split(' ');

        if (splitName.Length == 2)
        {
            firstName = fullName.Split(' ')[0];
            lastName = fullName.Split(' ')[1];
            shortName = CreateShortName(lastName);
        }
        else
        {
            firstName = fullName;
            shortName = CreateShortName(fullName);
        }

        stageResults = new List<string>();
	}

    string CreateShortName(string text)
    {
        if (text.Length > 3)
        {
            return text.Substring(0, 3).ToUpper();
        }
        else
        {
            return "N/A";
        }
    }

}
