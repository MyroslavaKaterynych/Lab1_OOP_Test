using Lab1_OOP.Controllers;

namespace Lab1_OOP;

class Program
{
    static void Main(string[] args)
    {
        MainController main_controller = new MainController();//Создаем объект контроллера
        main_controller.StartTest();//запускаем у контроллера метод стартТест


       
    }
}


public struct correctAnswer
{
    public string correct_question;
    public string correct_answer;


}