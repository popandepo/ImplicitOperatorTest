using ImplicitOperatorTest;

namespace ImplicitOperatorTestTests.LongNumberTests;

public class LongNumberTests_Pad
{
	public static string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

	public string GenerateString()
	{
		int length = new Random().Next(1, 10);
		var result = "";
		for (int i = 0; i < length; i++) result += numbers[new Random().Next(0, 10)];
		return result;
	}

	[Test]
	public void PadTimeTest()
	{
		var topStrings = new List<string>();
		var bottomStrings = new List<string>();
		
		var topStringsPad = new List<string>();
		var bottomStringsPad = new List<string>();

		for (int i = 0; i < 1_000_000; i++)
		{
			topStrings.Add(GenerateString());
			bottomStrings.Add(GenerateString());
		}

		LongNumber ln = 1;

		var padStart = DateTimeOffset.Now;
		for (int i = 0; i < topStrings.Count; i++)
		{
			var resp = ln.Pad(topStrings[i], bottomStrings[i]);
			topStringsPad.Add(resp.Top);
			bottomStringsPad.Add(resp.Bottom);
		}
		var padEnd = DateTimeOffset.Now;
		
		string padTime = (padEnd - padStart).ToString();

		for (int i = 0; i < topStrings.Count; i++)
		{
			Assert.That(topStringsPad[i], Has.Length.EqualTo(bottomStringsPad[i].Length), $"padded string {i}: \"{topStringsPad[i]}\", \"{bottomStringsPad[i]}\"");
		}
		
		Assert.Pass($"Pad time: {padTime}");
	}
}