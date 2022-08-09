using ImplicitOperatorTest;

namespace ImplicitOperatorTestTests.LongNumberTests;

public class LongNumberTests_Subtract
{
	[Test]
	public void SubtractInt1()
	{
		LongNumber number1 = 1;
		LongNumber number2 = 1;
		LongNumber number3 = number1 - number2;
		Assert.That(number3.Value, Is.EqualTo("0"));
	}
	
	[Test]
	public void SubtractInt2()
	{
		LongNumber number1 = 1;
		LongNumber number2 = 2;
		LongNumber number3 = number1 - number2;
		Assert.That(number3.Value, Is.EqualTo("-1"));
	}
}