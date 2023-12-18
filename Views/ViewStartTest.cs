using System;
namespace Lab1_OOP.Views
{
	public static class ViewStartTest
	{
		public static void StartTest()
		{
			Console.WriteLine("Start Test. Click Enter ");
			Console.ReadLine();
		}
		public static List<double> work_test(List<Task> tasks)
		{
            List<double> results = new List<double>();
            foreach (var task in tasks)
            {
                results.Add(task.ask_questions());
            }
			return results;
        }
		public static void show_results(List<Task> tasks, List<double> results)
		{

            double sum_result = 0;
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"Питання {i + 1}: {results[i]} б.");
                sum_result += results[i];
            }
            Console.WriteLine($"Всього: {sum_result} б.");
        }

    }
}

