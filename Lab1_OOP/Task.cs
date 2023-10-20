using System;
namespace Lab1_OOP
{
    public abstract class Task
    {
        public string question;
        public double assessment;//оцінка за вірну відповідь
        public virtual double ask_questions()
        {

            return 0;
        }
       
    }
}

