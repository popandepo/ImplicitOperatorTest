using ImplicitOperatorTest;

namespace ImplicitOperatorTestTests.LongNumberTests;

public class LongNumberTests_Constructor
{
	[Test]
	public void LongNumber_ConstructorTestInt1()
	{
		LongNumber number = 1;
		Assert.That(number.Value, Is.EqualTo("1"));
	}
	
	[Test]
	public void LongNumber_ConstructorTestInt2()
	{
		LongNumber number = -1;
		Assert.That(number.Value, Is.EqualTo("-1"));
	}
	
	[Test]
	public void LongNumber_ConstructorTestInt3()
	{
		LongNumber number = 0;
		Assert.That(number.Value, Is.EqualTo("0"));
	}
	
	[Test]
	public void LongNumber_ConstructorTestInt4()
	{
		LongNumber number = 123456789;
		Assert.That(number.Value, Is.EqualTo("123456789"));
	}
	
	[Test]
	public void LongNumber_ConstructorTestString1()
	{
		LongNumber number = "1";
		Assert.That(number.Value, Is.EqualTo("1"));
	}
	
	[Test]
	public void LongNumber_ConstructorTestString2()
	{
		LongNumber number = "-1";
		Assert.That(number.Value, Is.EqualTo("-1"));
	}
	
	[Test]
	public void LongNumber_ConstructorTestString3()
	{
		LongNumber number = "0";
		Assert.That(number.Value, Is.EqualTo("0"));
	}
	
	[Test]
	public void LongNumber_ConstructorTestString4()
	{
		LongNumber number = "123456789";
		Assert.That(number.Value, Is.EqualTo("123456789"));
	}
	
	[Test]
	public void LongNumber_ConstructorTestString5()
	{
		LongNumber number = "1234567890123456789";
		Assert.That(number.Value, Is.EqualTo("1234567890123456789"));
	}
}