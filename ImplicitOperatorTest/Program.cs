namespace ImplicitOperatorTest;

public class Program
{
	public static void Main(string[] args)
	{
		LongNumber ln = "999999999999999999999999999999999999999999999999999999999999999999999999999";
		int one = 1;
		LongNumber ln2 = ln + one;
	}

	public class LongNumber
	{
		public string Number;

		public LongNumber(string number)
		{
			Number = number;
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
			return ln1.Add(ln2);
		}

		private LongNumber Add(LongNumber ln)
		{
			int remainder = 0;
			string top = Number;
			string bottom = ln.Number;
			string result = "";
			
			// if the numbers are of different lengths, pad the shorter one with zeros
			if (top.Length < bottom.Length)
			{
				top = top.PadLeft(bottom.Length, '0');
			}
			else if (bottom.Length < top.Length)
			{
				bottom = bottom.PadLeft(top.Length, '0');
			}
			
			for (int i = Math.Max(top.Length - 1, bottom.Length - 1); i >= 0; i--)
			{
				int topDigit = int.Parse(char.ToString(top.ElementAtOrDefault(i)));
				int bottomDigit = int.Parse(char.ToString(bottom.ElementAtOrDefault(i)));
				int added = topDigit + bottomDigit + remainder;
				remainder = added > 9 ? int.Parse(char.ToString(added.ToString().ElementAtOrDefault(0))) : 0;
				result = result.Insert(0, char.ToString(added.ToString().ElementAtOrDefault(1)));
			}
			return remainder > 0 ? new LongNumber(result.Insert(0, remainder.ToString())) : new LongNumber(result);
		}

		public override string ToString()
		{
			//for readability, add a space every 3 digits from the right
			string result = Number;
			for (int i = result.Length - 3; i > 0; i -= 3)
			{
				result = result.Insert(i, " ");
			}
			return result;
		}
	}
}