using System;
namespace Task_Boldyrev;

	public class GenerateDouble:Valueprovider<double>
	{
    public override double Generate()
    {
        return random.NextDouble();
    }
    public override double ConvertFromString(string input_value)
    {
        return double.Parse(input_value);
    }
}

