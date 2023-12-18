using System;
using System.Threading.Tasks;
using Lab1_OOP.Models;
using Lab1_OOP.Views;

namespace Lab1_OOP.Controllers
{
	public class MainController
	{
		public void StartTest()
		{
			ViewStartTest.StartTest();//Говорит вьюшке, давай начинать
			ModelsQuestions model_tasks = new ModelsQuestions();//Создаст объект модели с вопросами. Запустит у него контруктор

            List<Task> sortedTasks = model_tasks.tasks.OrderBy(task => task.assessment).ToList();//Сортируем по возрастанию бала
			List<double> results = ViewStartTest.work_test(sortedTasks);//Запускаем вью с вопросами, получаем в ответ список баллов
			ViewStartTest.show_results(sortedTasks, results);//Выводим результаты в вьюшке
		}
		
	}
}

