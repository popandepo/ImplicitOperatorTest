using ImplicitOperatorTest;

namespace ImplicitOperatorTestTests.LongNumberTests;

public class LongNumberTests_Add
{
	[Test]
	public void AddInt1()
	{
		LongNumber number1 = 1;
		LongNumber number2 = 1;
		LongNumber number3 = number1 + number2;
		Assert.That(number3.Value, Is.EqualTo("2"));
	}
	
	[Test]
	public void AddInt2()
	{
		LongNumber number1 = 1;
		LongNumber number2 = 2;
		LongNumber number3 = number1 + number2;
		Assert.That(number3.Value, Is.EqualTo("3"));
	}
	
	[Test]
	public void AddInt3()
	{
		LongNumber number1 = 9;
		LongNumber number2 = 1;
		LongNumber number3 = number1 + number2;
		Assert.That(number3.Value, Is.EqualTo("10"));
	}
	
	[Test]
	public void AddInt4()
	{
		LongNumber number1 = 9;
		LongNumber number2 = 9;
		LongNumber number3 = number1 + number2;
		Assert.That(number3.Value, Is.EqualTo("18"));
	}
	
	[Test]
	public void AddInt5()
	{
		LongNumber number1 = 99;
		LongNumber number2 = 10;
		LongNumber number3 = number1 + number2;
		Assert.That(number3.Value, Is.EqualTo("109"));
	}

	[Test]
	public void AddString1()
	{
		LongNumber number1 = "1";
		LongNumber number2 = "1";
		LongNumber number3 = number1 + number2;
		Assert.That(number3.Value, Is.EqualTo("2"));
	}
	
	[Test]
	public void AddString2()
	{
		LongNumber number1 = "1";
		LongNumber number2 = "2";
		LongNumber number3 = number1 + number2;
		Assert.That(number3.Value, Is.EqualTo("3"));
	}
	
	[Test]
	public void AddString3()
	{
		LongNumber number1 = "9";
		LongNumber number2 = "1";
		LongNumber number3 = number1 + number2;
		Assert.That(number3.Value, Is.EqualTo("10"));
	}
	
	[Test]
	public void AddString4()
	{
		LongNumber number1 = "9";
		LongNumber number2 = "9";
		LongNumber number3 = number1 + number2;
		Assert.That(number3.Value, Is.EqualTo("18"));
	}
	
	[Test]
	public void AddString5()
	{
		LongNumber number1 = "99";
		LongNumber number2 = "10";
		LongNumber number3 = number1 + number2;
		Assert.That(number3.Value, Is.EqualTo("109"));
	}
	
	[Test]
	public void AddString6()
	{
		LongNumber number1 = "99";
		LongNumber number2 = "99";
		LongNumber number3 = number1 + number2;
		Assert.That(number3.Value, Is.EqualTo("198"));
	}
	
	[Test]
	public void AddString7()
	{
		LongNumber number1 = "999999999999999999999999999999999999999999";
		LongNumber number2 = "1";
		LongNumber number3 = number1 + number2;
		Assert.That(number3.Value, Is.EqualTo("1000000000000000000000000000000000000000000"));
	}
}