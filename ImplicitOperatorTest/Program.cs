namespace ImplicitOperatorTest;

public partial class Program
{
	public static void Main(string[] args)
	{
		string str = "Hello World";
		try
		{ 
			while (true)
		{
			str += str;
		}

		}
		catch (Exception e)
		{
			Console.WriteLine("Finished at "+str.Length);
			throw;
		}

		LongNumber ln = 5;
		int one = 1;
		LongNumber ln2 = ln + one;
		LongNumber ln3 = ln - "1";
	}
}