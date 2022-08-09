using ImplicitOperatorTest;

namespace ImplicitOperatorTestTests.LongNumberTests;

public class LongNumbers_Constructor
{
	[Test]
	public void ConstructorInt1()
	{
		LongNumber number = 1;
		Assert.That(number.Value, Is.EqualTo("1"));
	}
	
	[Test]
	public void ConstructorInt2()
	{
		LongNumber number = -1;
		Assert.That(number.Value, Is.EqualTo("-1"));
	}
	
	[Test]
	public void ConstructorInt3()
	{
		LongNumber number = 0;
		Assert.That(number.Value, Is.EqualTo("0"));
	}
	
	[Test]
	public void ConstructorInt4()
	{
		LongNumber number = 123456789;
		Assert.That(number.Value, Is.EqualTo("123456789"));
	}
	
	[Test]
	public void ConstructorString1()
	{
		LongNumber number = "1";
		Assert.That(number.Value, Is.EqualTo("1"));
	}
	
	[Test]
	public void ConstructorString2()
	{
		LongNumber number = "-1";
		Assert.That(number.Value, Is.EqualTo("-1"));
	}
	
	[Test]
	public void ConstructorString3()
	{
		LongNumber number = "0";
		Assert.That(number.Value, Is.EqualTo("0"));
	}
	
	[Test]
	public void ConstructorString4()
	{
		LongNumber number = "123456789";
		Assert.That(number.Value, Is.EqualTo("123456789"));
	}
	
	[Test]
	public void ConstructorString5()
	{
		LongNumber number = "1234567890123456789";
		Assert.That(number.Value, Is.EqualTo("1234567890123456789"));
	}
}