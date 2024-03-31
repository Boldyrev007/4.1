using System;
namespace Task_Boldyrev;

public abstract class Valueprovider<T>
{
	protected Random random = new Random();
	public abstract T Generate();
	public abstract T ConvertFromString(string input_value);
}

