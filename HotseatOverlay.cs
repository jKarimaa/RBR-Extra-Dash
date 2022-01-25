using System;
using System.Collections.Generic;

public class HotseatOverlay
{
    public List<Driver> drivers;
    
	public HotseatOverlay()
	{
        drivers =  new List<Driver>();
        drivers.Add(new Driver("Joona"));
	}

}
