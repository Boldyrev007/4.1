using System;
namespace Task_Boldyrev;

	public class GenerateBoolen : Valueprovider<bool>
	{
    public override bool Generate()
    {
        if(random.Next(0,2) == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override bool ConvertFromString(string input_value)
    {
        return bool.Parse(input_value);
    }
}

