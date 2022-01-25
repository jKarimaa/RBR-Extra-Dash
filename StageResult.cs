using System;

public class StageResult
{
    public TimeSpan stageTime;
    public string trackName;

	public StageResult(TimeSpan time, string stage)
	{
        stageTime = time;
        trackName = stage;
	}
}