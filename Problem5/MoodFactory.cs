using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    abstract class MoodFactory
    {
        public abstract int CalculateMoodPoints(Food food);
        public abstract string CalculateMoodType();
    }

    class Mood : MoodFactory
    {
        #region Fields 
        int moodPoints;
        string moodType;
        #endregion

        #region Properties
        public int MoodPoints
        {
            get { return moodPoints; }
            set { moodPoints = value; }
        }

        public string MoodType
        {
            get { return moodType; }
            set { moodType = value; }
        }
        #endregion

        #region Methods
        public override int CalculateMoodPoints(Food food)
        {
            int points = 0;

            for (int i = 0; i < food.Foods.Count; i++)
            {
                if(food.Foods[i] == "Cram")
                {
                    points += 2;
                }
                else if (food.Foods[i] == "Lembas")
                {
                    points += 3;
                }
                else if (food.Foods[i] == "Apple")
                {
                    points += 1;
                }
                else if (food.Foods[i] == "Melon")
                {
                    points += 1;
                }
                else if (food.Foods[i] == "HoneyCake")
                {
                    points += 5;
                }
                else if (food.Foods[i] == "Mushrooms")
                {
                    points -= 10;
                }
                else
                {
                    points -= 1;
                }
            }

            return points;
        }

        public override string CalculateMoodType()
        {
            string mood = null;

            if(MoodPoints < -5)
            {
                mood = "Angry";
            }
            else if(MoodPoints >= -5 && MoodPoints <= 0)
            {
                mood = "Sad";
            }
            else if(MoodPoints >= 1 && MoodPoints <= 15)
            {
                mood = "Happy";
            }
            else if (MoodPoints > 15)
            {
                mood = "JavaScript";
            }

            return mood;
        }
        #endregion
    }
}
