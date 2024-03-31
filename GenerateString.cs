using System;
namespace Task_Boldyrev;

public class GenerateString:Valueprovider<string>
{
	string string_values1 = "dkfjhfkjhruldhfjsjrhkjfnwisiid";

	public override string Generate()
	{
		int length = 6;
		char[] chars = new char[length];
		for(int i = 0; i < length; i++)
		{
			chars[i] = string_values1[random.Next(0, string_values1.Length)];
		}
		return new string(chars);
	}
	public override string ConvertFromString(string input_value)
	{
		return input_value;
	}
}

