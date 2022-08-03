namespace ImplicitOperatorTest;

public partial class Program
{
	public static void Main(string[] args)
	{
		LongNumber ln = 5;
		int one = 1;
		LongNumber ln2 = ln + one;
		LongNumber ln3 = ln - "1";
	}
}