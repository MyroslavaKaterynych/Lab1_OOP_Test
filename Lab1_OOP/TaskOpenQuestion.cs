using System;
namespace Lab1_OOP
{
	public class TaskOpenQuestion: Task 
	{
		public string corect_answer;//правильна відповідь
        //public string question;
        //public int assessment;//оцінка за вірну відповідь
		
        public TaskOpenQuestion(string question, string corect_answer,int assessment)
		{
			this.question = question;
			this.corect_answer = corect_answer;
			this.assessment = assessment;

		}
		public override double ask_questions()
		{
            Console.WriteLine("Питання: " + question);
            
            Console.WriteLine("Введіть правильну відповідь");
            string result = Console.ReadLine();
			if (corect_answer.ToUpper() == result.ToUpper())
			{
				return assessment;
			}
			else
				return 0;
        }

    }
}

