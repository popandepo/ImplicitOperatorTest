namespace ImplicitOperatorTest;

public class LongNumber
{
	public string Value;

	public LongNumber(string value)
	{
		Value = value;
	}

	public static implicit operator LongNumber(string number)
	{
		return new LongNumber(number);
	}

	public static implicit operator LongNumber(int number)
	{
		return new LongNumber(number.ToString());
	}

	public static LongNumber operator +(LongNumber ln1, LongNumber ln2)
	{
		string result = ln1.Add(ln2).Value;
		return result;
	}

	public (string top, string bottom) Pad(string top, string bottom)
	{
		if (top.Length < bottom.Length)
			top = top.PadLeft(bottom.Length, '0');
		else if (bottom.Length < top.Length) bottom = bottom.PadLeft(top.Length, '0');

		return (top, bottom);
	}

	public LongNumber Add(LongNumber ln)
	{
		var remainder = 0;
		string top = Value;
		string bottom = ln.Value;
		var result = "";

		var padded = Pad(top, bottom);
		top = padded.top;
		bottom = padded.bottom;

		for (int i = Math.Max(top.Length - 1, bottom.Length - 1); i >= 0; i--)
		{
			int topDigit = ParseStringAsInt(top, i);
			int bottomDigit = ParseStringAsInt(bottom, i);

			int sum = AddDigits(topDigit, bottomDigit, remainder);

			remainder = GetRemainder(sum);
			result = result.Insert(0, char.ToString(sum.ToString().LastOrDefault()));
		}

		Value = remainder > 0 ? result.Insert(0, remainder.ToString()) : result;
		return this;
	}

	public int GetRemainder(int sum)
	{
		return sum > 9 ? ParseStringAsInt(sum.ToString(), 0) : 0;
	}

	public static int ParseStringAsInt(string str, int position)
	{
		return int.Parse(char.ToString(str.ElementAtOrDefault(position)));
	}

	public int AddDigits(int topDigit, int bottomDigit, int remainder)
	{
		return topDigit + bottomDigit + remainder;
	}

	public static LongNumber operator -(LongNumber ln1, LongNumber ln2)
	{
		return ln1.Subtract(ln2);
	}

	public LongNumber Subtract(LongNumber ln2)
	{
		var remainder = 0;
		string top = Value;
		string bottom = ln2.Value;
		var result = "";

		var padded = Pad(top, bottom);
		top = padded.top;
		bottom = padded.bottom;

		for (int i = Math.Max(top.Length - 1, bottom.Length - 1); i >= 0; i--)
		{
			int topDigit = int.Parse(char.ToString(top.ElementAtOrDefault(i)));
			int bottomDigit = int.Parse(char.ToString(bottom.ElementAtOrDefault(i)));
			int subtracted = topDigit - bottomDigit - remainder;
			remainder = subtracted < 0 ? 1 : 0;
			result = result.Insert(0, char.ToString(subtracted.ToString().ElementAtOrDefault(1)));
		}

		return result;
	}

	// public override string ToString()
	// {
	// 	//for readability, add a space every 3 digits from the right
	// 	string result = Value;
	// 	for (int i = result.Length - 3; i > 0; i -= 3)
	// 	{
	// 		result = result.Insert(i, " ");
	// 	}
	// 	return result;
	// }
}