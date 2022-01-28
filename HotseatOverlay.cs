using System;
using System.Linq;
using System.Collections.Generic;

public class HotseatOverlay
{
    public List<Driver> drivers;

    public DateTime started;
    
	public HotseatOverlay()
	{
        started = DateTime.Now;
        drivers = new List<Driver>();
    }

    public void AddDriver(Driver driver)
    {
        drivers.Add(driver);
    }

/*    public void UpdateRallyPositions()
    {
        List<RallyResult> positionedResults = rallyResults.OrderBy(o => o.rallyTime).ToList();

        TimeSpan timeToCompare = positionedResults[0].rallyTime;

        foreach (RallyResult result in positionedResults)
        {
            result.diffFirst = result.rallyTime - timeToCompare;
        }

        rallyResults = positionedResults;
    }*/
}
