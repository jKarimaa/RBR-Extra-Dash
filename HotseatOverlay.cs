using System;
using System.Collections.Generic;

public class HotseatOverlay
{
    public List<Driver> drivers;
    public List<RallyResult> rallyResults;
    
	public HotseatOverlay()
	{
        drivers =  new List<Driver>();
        rallyResults = new List<RallyResult>();


        rallyResults.Add(new RallyResult(new Driver("Joona", "Karimaa")));
        rallyResults[0].AddStageResult(new TimeSpan(0, 0, 2, 32, 446), "Ouninpohja");
    }

    public void UpdateHotseatOverlay()
    {

    }

}
