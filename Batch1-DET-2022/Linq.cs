using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Linq
    {
        public static void Main()
        {

            //The three parts of a Linq Query: deffered execution
            // 1.Data Source.

            // List<int> numbers = new List<int>();
            //numbers.Add(110);
            //numbers.Add(100);
            //numbers.Add(105);
            //numbers.Add(102);

            //2.Query creation.sql type
            //  var numQuery = from num in numbers //select num from numbers
            //                 select num;

            //var numQuery = from num in numbers //select num from numbers
            //               where num > 102
            //               select num;

            //lamda exp

            //  var numQuery = numbers.Select(x => x);

            //early execution
            //  var numQuery = (from num in numbers     //select num from numbers
            //                  select num).ToList();

            //numbers.Add(200);

            //lamda exp
            // var numQuery = numbers.Where(x => x > 102);

            //3.Query execution.

            // foreach (int num in numQuery)
            //{
            //    Console.WriteLine("{0}", num);
            //    num.Dump(); // this is for LinQpad not for vs
            //}
            //Console.ReadLine();

            //Order by Simple

            //int[] numbers = { 7, 9, 5 };

            //var result = numbers.OrderBy(n => n);

            //Console.WriteLine("Ordered list of numbers:");
            //foreach (int number in result)
            //    Console.WriteLine(number);

            //Order By Descending

            //string[] names = { "Ned", "Ben", "Susan" };

            //var result = names.OrderByDescending(n => n);

            //Console.WriteLine("Descending ordered list of names:");
            //foreach (string name in result)
            //    Console.WriteLine(name);

            //Reverse

            //char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };

            //var result = characters.Reverse();

            //Console.WriteLine("Characters in reverse order:");
            //foreach (char character in result)
            //    Console.WriteLine(character);


            //Then By
            //string[] capitals = { "Banglore", "Hyderabad", "Mumbai", "Lucknow", "Pune",
            //              "Goa", "Kerala", "Kashmir" };

            //var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            //Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            //foreach (string capital in result)
            //    Console.WriteLine(capital);

            //Then by Descending

            //        var dates = new DateTime[] {
            //    new DateTime(2015, 3, 1),
            //    new DateTime(2014, 7, 1),
            //    new DateTime(2013, 5, 1),
            //    new DateTime(2015, 1, 1),
            //    new DateTime(2015, 7, 1)
            //};

            //        var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            //        Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            //        foreach (DateTime dt in result)
            //            Console.WriteLine(dt.ToString("yyyy/MM/dd"));

            //Partitioning...Skip

            //string[] words = { "one", "two", "three", "four", "five", "six" };

            //var result = words.Skip(4);

            //Console.WriteLine("Skips the first 4 words:");
            //foreach (string word in result)
            //    Console.WriteLine(word);

            //skip while
            //string[] words = { "one", "two", "three", "four", "five", "six" };

            //var result = words.SkipWhile(w => w.Length == 3);

            //Console.WriteLine("Skips words while the condition is met:");
            //foreach (string word in result)
            //    Console.WriteLine(word);

            //Take
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.Take(5);

            //Console.WriteLine("Takes the first 5 numbers only:");
            //foreach (int number in result)
            //    Console.WriteLine(number);

            //TakeWhile
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.TakeWhile(n => n < 5);

            //Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            //foreach (int number in result)
            //    Console.WriteLine(number);

            //1.Aggregation (Simple) Multiply
            //var numbers = new int[] { 1, 2, 3, 4, 5 };

            //var result = numbers.Aggregate((a, b) => a * b);

            //Console.WriteLine("Aggregated numbers by multiplication:");
            //Console.WriteLine(result);

            //2.Aggregation (Average)
            //int[] numbers = { 9, 9, 10, 10 };

            //var result = numbers.Average();

            //Console.WriteLine("Average is:");
            //Console.WriteLine(result);

            //3.Aggregation (Count) counting names
            //string[] names = { "syed", "Tabrej", "Alia bhatt", "Ranber kapoor", "Shahrukh khan" };

            //var result = names.Count();

            //Console.WriteLine("Counting names gives:");
            //Console.WriteLine(result);

            //4.Aggregation Max Higghest num
            //int[] numbers = { 2, 8, 5, 6, 1 };

            //var result = numbers.Max();

            //Console.WriteLine("Highest number is:");
            //Console.WriteLine(result);

            //5.Aggregation min Lowest num
            //int[] numbers = { 6, 9, 3, 7, 5 };

            //var result = numbers.Min();

            //Console.WriteLine("Lowest number is:");
            //Console.WriteLine(result);

            //6.Agregation Sum Adding
            //int[] numbers = { 20, 55, 105 };

            //var result = numbers.Sum();

            //Console.WriteLine("Summing the numbers yields:");
            //Console.WriteLine(result);



            //1.Element At {0,1,2}
            //string[] words = { "One", "Two", "Three" };

            //var result = words.ElementAt(1);

            //Console.WriteLine("Element at index 1 in the array is:");
            //Console.WriteLine(result);

            //2.Element At Or Default boolean return 

            //string[] colors = { "Red", "Green", "Blue" };

            //var resultIndex1 = colors.ElementAtOrDefault(1);

            //var resultIndex10 = colors.ElementAtOrDefault(10);

            //Console.WriteLine("Element at index 1 in the array contains:");
            //Console.WriteLine(resultIndex1);

            //Console.WriteLine("Element at index 10 in the array does not exist:");
            //Console.WriteLine(resultIndex10 == null);

            //3.Elements(First Simple) 1ST
            //string[] fruits = { "Banana", "Apple", "Orange" };

            //var result = fruits.First();

            //Console.WriteLine("First element in the array is:");
            //Console.WriteLine(result);

            //4.Elements(First Conditional) 1st 6
            //string[] countries = { "Denmark", "Sweden", "Norway" };

            //var result = countries.First(c => c.Length == 6);

            //Console.WriteLine("First element with a length of 6 characters:");
            //Console.WriteLine(result);

            //5.Elements(FirstOrDefault)
            //string[] countries = { "Denmark", "Sweden", "Norway" };
            //string[] empty = { };

            //var result = countries.FirstOrDefault();

            //var resultEmpty = empty.FirstOrDefault();

            //Console.WriteLine("First element in the countries array contains:");
            //Console.WriteLine(result);

            //Console.WriteLine("First element in the empty array does not exist:");
            //Console.WriteLine(resultEmpty == null);

            //6.Elements (Last) last num
            //int[] numbers = { 7, 3, 5 };

            //var result = numbers.Last();

            //Console.WriteLine("Last number in array is:");
            //Console.WriteLine(result);


            //7.Element(LastOrDefault (simp))
            //string[] words = { "one", "two", "three" };
            //string[] empty = { };

            //var result = words.LastOrDefault();

            //var resultEmpty = empty.LastOrDefault();

            //Console.WriteLine("Last element in the words array contains:");
            //Console.WriteLine(result);

            //Console.WriteLine("Last element in the empty array does not exist:");
            //Console.WriteLine(resultEmpty == null);

            //8.Element (LastOrDefault (cond.)) length
            //string[] words = { "one", "two", "three" };

            //var result = words.LastOrDefault(w => w.Length == 3);

            //var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

            //Console.WriteLine("Last element in the words array having a length of 3:");
            //Console.WriteLine(result);

            //Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            //Console.WriteLine(resultNoMatch == null);

            //9.Elements (Single) 
            //string[] names1 = { "Peter" };
            //string[] names3 = { "Peter", "Joe", "Wilma" };
            //string[] empty = { };

            //var result1 = names1.Single();

            //Console.WriteLine("The only name in the array is:");
            //Console.WriteLine(result1);

            //try
            //{
            //    // This will throw an exception because array contains no elements
            //    var resultEmpty = empty.Single();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    // This will throw an exception as well because array contains more than one element
            //    var result3 = names3.Single();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //10.Element (SingleOrDefault)
            //string[] names1 = { "Peter" };
            //string[] names3 = { "Peter", "Joe", "Wilma" };
            //string[] empty = { };

            //var result1 = names1.SingleOrDefault();

            //var resultEmpty = empty.SingleOrDefault();

            //Console.WriteLine("The only name in the array is:");
            //Console.WriteLine(result1);

            //Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            //Console.WriteLine(resultEmpty == null);

            //try
            //{
            //    // This will throw an exception as well because array contains more than one element
            //    var result3 = names3.SingleOrDefault();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            // }


            //1.Quantifiers(All)
            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

            //var result = names.All(n => n.StartsWith("B"));

            //Console.WriteLine("Does all of the names start with the letter 'B':");
            //Console.WriteLine(result);

            //2.Quantifiers(Any)

            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

            //var result = names.Any(n => n.StartsWith("B"));

            //Console.WriteLine("Does any of the names start with the letter 'B':");
            //Console.WriteLine(result);


            //3.Quantifiers (Contains)
            //int[] numbers = { 1, 3, 5, 7, 9 };

            //var result = numbers.Contains(5);

            //Console.WriteLine("sequence contains the value 5:");
            //Console.WriteLine(result);

            //1.Set (Distinct) duplicate it removes
            //int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

            //var result = numbers.Distinct();

            //Console.WriteLine("Distinct removes duplicate elements:");
            //foreach (int number in result)
            //    Console.WriteLine(number);


            //Array names

            //string[] names = { "john", "peter", "jacob", "marry", "jackson" };

            //var names1 = from a in names
            //             where a.Contains("o")
            //             select a;
            //foreach (string a in names1)
            //    Console.WriteLine(a);

            //Array Max

            //string[] names = { "john", "peter", "jacob", "harry", "jackson" };

            //var names2 = names.OrderByDescending(x => x.Length);
            //var biggest = names2.Take(1);

            //foreach(var name in biggest)
            //{
            //    Console.WriteLine(name);
            //}



            //List<string> words = new List<string> { "basket", "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };


            //var wordsGroups = words.GroupBy(x => x.Length).Select(y => new { FirstLetter = y.Key, Words = y });

            //foreach (var item in wordsGroups)
            //{

            //    Console.WriteLine("Words that start with the" + "letter '{0}'  :", item.FirstLetter);

            //    foreach (var w in item.Words)
            //    {
            //        Console.WriteLine(w);
            //    }


            //}




        }

    }
}




