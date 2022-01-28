using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SQLite;

public class HotseatOverlay
{
    public List<Driver> drivers;
    public List<RallyResult> rallyResults;
    
	public HotseatOverlay()
	{
        drivers =  new List<Driver>();
        rallyResults = new List<RallyResult>();


        rallyResults.Add(new RallyResult(new Driver("Joona", "Karimaa")));
        rallyResults[0].AddStageResult(new TimeSpan(0, 0, 16, 32, 446), "Ouninpohja");

        rallyResults.Add(new RallyResult(new Driver("Timo", "Elonen")));
        rallyResults[1].AddStageResult(new TimeSpan(0, 0, 16, 12, 534), "Ouninpohja");

        rallyResults.Add(new RallyResult(new Driver("Timo", "Ruokolainen")));
        rallyResults[2].AddStageResult(new TimeSpan(0, 0, 16, 20, 107), "Ouninpohja");

        UpdateRallyPositions();
    }

    public void UpdateRallyPositions()
    {
        List<RallyResult> positionedResults = rallyResults.OrderBy(o => o.rallyTime).ToList();

        TimeSpan timeToCompare = positionedResults[0].rallyTime;

        foreach (RallyResult result in positionedResults)
        {
            result.diffFirst = result.rallyTime - timeToCompare;
        }

        rallyResults = positionedResults;
    }

}
