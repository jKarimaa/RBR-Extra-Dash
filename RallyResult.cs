using System;
using System.Collections.Generic;

public class RallyResult
{
    public List<StageResult> stageTimes;
    public TimeSpan rallyTime;
    public Driver rallyDriver;

	public RallyResult(Driver driver)
	{
        stageTimes = new List<StageResult>();
        rallyDriver = driver;
	}

    public void AddStageResult(TimeSpan stageTime, string stage)
    {
        stageTimes.Add(new StageResult(stageTime, stage));
        UpdateRallyTime();
    }

    public void UpdateRallyTime()
    {
        foreach (StageResult result in stageTimes)
        {
            rallyTime += result.stageTime;
        }
    }
}


