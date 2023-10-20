namespace Lab1_OOP;

class Program
{
    static void Main(string[] args)
    {
        var factory = new TaskFactory();

        // Create a TaskCompliance
        var complianceTask = factory.CreateTask(TaskType.Compliance, "Which options are correct?", 10, new ComplianceParameters
        {
            ListQuestion = new List<string> { "Q1", "Q2" },
            ListAnswers = new List<string> { "A1", "A2" },
            ListCorrectAnswers = new List<correctAnswer> { new correctAnswer { correct_answer = "A1" }, new correctAnswer { correct_answer = "A2" } }
        });

        // Create a TaskMultipleOption
        var multipleOptionTask = factory.CreateTask(TaskType.MultipleOption, "Select correct options:", 5, new MultipleOptionParameters
        {
            AnswerOptions = new List<string> { "Option 1", "Option 2", "Option 3" },
            Answers = new List<string> { "Option 1", "Option 2" },
            CountCorrectAnswer = 2
        });

        // Create a TaskOpenQuestion
        var openQuestionTask = factory.CreateTask(TaskType.OpenQuestion, "What is the capital of France?", 5, new OpenQuestionParameters
        {
            CorrectAnswer = "Paris"
        });

        // Create a TaskSuquence
        var sequenceTask = factory.CreateTask(TaskType.Sequence, "Arrange the following in the correct order:", 10, new SequenceParameters
        {
            ListQuestion = new List<string> { "Q1", "Q2", "Q3" },
            ListAnswers = new List<string> { "A3", "A1", "A2" },
            ListCorrectAnswers = new List<correctAnswer>
            {
                new correctAnswer { correct_answer = "A1" },
                new correctAnswer { correct_answer = "A2" },
                new correctAnswer { correct_answer = "A3" }
            }
        });

        // Create a TaskTest
        var testTask = factory.CreateTask(TaskType.Test, "What is the capital of Spain?", 5, new TestParameters
        {
            AnswerOptions = new List<string> { "Madrid", "Barcelona", "Lisbon" },
            Answer = "Madrid"
        });

        // Conduct the tests
        var complianceScore = complianceTask.ask_questions();
        var multipleOptionScore = multipleOptionTask.ask_questions();
        var openQuestionScore = openQuestionTask.ask_questions();
        var sequenceScore = sequenceTask.ask_questions();
        var testScore = testTask.ask_questions();

        Console.WriteLine("TaskCompliance Score: " + complianceScore);
        Console.WriteLine("TaskMultipleOption Score: " + multipleOptionScore);
        Console.WriteLine("TaskOpenQuestion Score: " + openQuestionScore);
        Console.WriteLine("TaskSuquence Score: " + sequenceScore);
        Console.WriteLine("TaskTest Score: " + testScore);


    }
}


public struct correctAnswer
{
    public string correct_question;
    public string correct_answer;


}