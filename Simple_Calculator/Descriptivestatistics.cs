
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;

namespace examination_1
{
	//class that returns Descriptive statistics objects 
	public static class Descriptivestatistics
	{
		//Exceptionhandling handles new exceptions of jsondata and throws the exceptions
		public static int[] Exceptionhandling(int[] source) //validatearray some namn istället 
		{
			if (source == null)
			{
				throw new ArgumentNullException();
			}
			else if (source.Length == 0)
			{
				throw new InvalidOperationException("Sequence contains no elements");
			}
			return source;
		}
		// the mean technically is the average. with system Linq the higher function .Average() lets us calculate that. 
		public static double Mean (int[] source) {
			Exceptionhandling(source);
			return source.Average();

		}

	//Median returns median. It is a double because it takes more than 8 bytes
		public static double Median (int[] source) {
			Exceptionhandling(source);
            Array.Sort(source);
            int amount = source.Length;
            int middle = amount / 2;
            return (amount % 2 == 0) ? (source[middle-1] + source[middle]) / 2 : source[(amount - 1) / 2];
        
		}
		
		//static int returns Mode
		//using linq will let us use .Select, .Groupby, .orderdescending and .first functions that allow to map Mode
		public static int[] Mode (int[] source) {
			Exceptionhandling(source);
			 Array.Sort(source);

            var most = source.GroupBy(i => i)
				.Select(i => new { addup = i.Count(), number = i.Key })
                .GroupBy(i => i.addup, i => i.number)
                .OrderByDescending(i => i.Key)
            	.First();

            return most.ToArray();
            
		}
		//static int returns minimum with C# .Min function 
		public static int Minimum (int[] source) {
			Exceptionhandling(source);
			return source.Min();

		}
		// returns Maximum with .Max() function 
		public static int Maximum (int[] source) {
			Exceptionhandling(source);
			return source.Max();

		}

		//public static int returns .Max()-.Min, sorts through json file and returns range
		public static int Range (int[] source) {
			Exceptionhandling(source);
			return source.Max() - source.Min();
		}

		//public static double returns StandardDev from json file
		public static double StandardDeviation (int[] source) {
			Exceptionhandling(source);
			//linq lets program add higher functions for getting average(mean), x-mean times x-mean added together
			//then return the square root of double sd divided by json files array length 
			double sd = source.Select(x => (x - source.Average()) * (x - source.Average())).Sum();
			return Math.Sqrt(sd / source.Length);

		}

		//static dynamic returns Descriptive stats objects 
		public static dynamic Descriptivestats(int[] source) {
			Exceptionhandling(source);
	
			dynamic descriptives = new {
				Mean = Descriptivestatistics.Mean(source),
				Median = Descriptivestatistics.Median(source),
				Mode = Descriptivestatistics.Mode(source),
				Minimum = Descriptivestatistics.Minimum(source),
				Maximum = Descriptivestatistics.Maximum(source),
				Range = Descriptivestatistics.Range(source),
				StandardDeviation = Descriptivestatistics.StandardDeviation(source),
			};
			//returns interpolated string of each object 
			return
				$" Mean: {descriptives.Mean}, Median: {descriptives.Median},  Mode: {string.Join("," , descriptives.Mode)}, Mininimum: {descriptives.Minimum}"
				+ $" Maximum: {descriptives.Maximum}, Range: {descriptives.Range}, StandardDeviation: {descriptives.StandardDeviation}";
		}

	}
}