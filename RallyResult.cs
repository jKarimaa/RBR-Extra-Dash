using System;
using System.Collections.Generic;

public class RallyResult
{
    public List<StageResult> stageTimes;
    public Driver rallyDriver;

	public RallyResult(Driver driver)
	{
        rallyDriver = driver;
	}

    public void AddTime(TimeSpan stageTime)
    {
        stageTimes.Add(new StageResult(stageTime, rallyDriver));
    }
}


