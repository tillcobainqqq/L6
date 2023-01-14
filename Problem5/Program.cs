using System;

namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food food = new Food();
            Mood mood = new Mood();

            food.addFoods();
            mood.MoodPoints = mood.CalculateMoodPoints(food);
            mood.MoodType = mood.CalculateMoodType();
            
            Console.WriteLine();

            Console.WriteLine("Mood points: " + mood.MoodPoints);
            Console.WriteLine("Mood: " + mood.MoodType);
        }
    }
}
