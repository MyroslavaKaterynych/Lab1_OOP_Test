using System;
namespace Lab1_OOP
{/// <summary>
/// 
/// </summary>
    class TaskTest : Task
    {
        public List<string> answer_options;//варіанти відповідей на тест
        public string answer;//вірна відповідь(а-відповідь)
        private List<LetterForTest> lettersForTest = new List<LetterForTest>();//список букв варіантів відповідей

        public TaskTest(string question, List<string> answer_options, string answer, int assessment)
        {
            this.question = question;
            this.answer_options = answer_options;
            this.answer = answer;
            this.assessment = assessment;
            lettersForTest.Add(new LetterForTest() {letter='А'} );
            lettersForTest.Add(new LetterForTest() {letter = 'Б' });
            lettersForTest.Add(new LetterForTest() { letter = 'В' });
            lettersForTest.Add(new LetterForTest() {letter = 'Г' });
            lettersForTest.Add(new LetterForTest() {letter = 'Д' });
            lettersForTest.Add(new LetterForTest() { letter = 'Е' });
        }
        public override double ask_questions()
        {
            Console.WriteLine("Питання: " + question);
            for (int i = 0; i < answer_options.Count; i++)
            {
                Console.WriteLine(lettersForTest[i].letter +" - "+ answer_options[i]);

            }
            Console.WriteLine("Виберіть варіант відповіді(вкажіть букву)");
            string result = Console.ReadLine().ToUpper();
            int number_correct_answer = -1;
            for (int i = 0; i < answer_options.Count; i++)
            {
                if (answer_options[i] == answer)
                {
                    number_correct_answer = i;
                    break;
                }
            }
            int number_our_answer = -1;
            for (int i = 0; i < lettersForTest.Count; i++)
            {
                if (lettersForTest[i].letter.ToString() == result)
                {
                    number_our_answer = i;
                    break;
                }
            }
            if (number_correct_answer == number_our_answer)
            {
                return assessment;
            }
            else
                return 0;
        }
        
    }

}

