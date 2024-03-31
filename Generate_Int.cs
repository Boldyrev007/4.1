using System;
namespace Task_Boldyrev;

public class Generate_Int : Valueprovider<int>
{
	public override int Generate()
	{
		int rand = random.Next(0, 51);
		return rand;
	}
	public override int ConvertFromString(string input_value)
	{
		return int.Parse(input_value);
	}
}

