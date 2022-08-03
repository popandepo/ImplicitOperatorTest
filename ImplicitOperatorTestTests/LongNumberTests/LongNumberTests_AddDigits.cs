using ImplicitOperatorTest;

namespace ImplicitOperatorTestTests.LongNumberTests;

public class LongNumberTests_AddDigits
{
	[Test]
	public void LongNumber_AddDigitsTestInt1()
	{
		LongNumber num = 1;
		var resp = num.AddDigits(1,1,0);
		Assert.That(resp, Is.EqualTo(2));
	}

	[Test]
	public void LongNumber_AddDigitsTestInt2()
	{
		LongNumber num = 1;
		var resp = num.AddDigits(1,0,1);
		Assert.That(resp, Is.EqualTo(2));
	}

	[Test]
	public void LongNumber_AddDigitsTestInt3()
	{
		LongNumber num = 1;
		var resp = num.AddDigits(1,1,1);
		Assert.That(resp, Is.EqualTo(3));
	}

	[Test]
	public void LongNumber_AddDigitsTestInt4()
	{
		LongNumber num = 1;
		var resp = num.AddDigits(9,9,9);
		Assert.That(resp, Is.EqualTo(27));
	}
}