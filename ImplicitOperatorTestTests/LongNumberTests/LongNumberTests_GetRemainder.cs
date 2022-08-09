using ImplicitOperatorTest;

namespace ImplicitOperatorTestTests.LongNumberTests;

public class LongNumberTests_GetRemainder
{
	[Test]
	public void GetRemainder_1()
	{
		LongNumber num = 1;

		var remainder = num.GetRemainder(1);
		
		Assert.That(remainder, Is.EqualTo(0));
	}
	
	[Test]
	public void GetRemainder_2()
	{
		LongNumber num = 1;
		
		var remainder = num.GetRemainder(10);
		
		Assert.That(remainder, Is.EqualTo(1));
	}
	
	[Test]
	public void GetRemainder_3()
	{
		LongNumber num = 1;
		
		var remainder = num.GetRemainder(20);
		
		Assert.That(remainder, Is.EqualTo(2));
	}
}