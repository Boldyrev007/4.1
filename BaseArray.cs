using System;
namespace Task_Boldyrev;

public abstract class BaseArray<T> : IBaseArray
{
	protected Valueprovider<T> generator;
	public abstract void Print();

	//public BaseArray(bool choice, Valueprovider<T> inputgenerator)
	//{
		//generator = inputgenerator;

		//Create(choice);
	//}

	//public virtual void Create(bool choice)
	//{
		//if (choice)
		//{
          //      fill_RandomArray();
            //}
		//else
		//{
          //      fillArray_by_User();
            //}
	//}

	//protected abstract void fill_RandomArray();

	//protected abstract void fillArray_by_User();

	//public abstract void Print();

    }

