using System;

public class StageResult
{
    public TimeSpan stageTime;
    public Driver stageDriver;

	public StageResult(TimeSpan time, Driver driver)
	{
        stageTime = time;
        stageDriver = driver;
	}
}


