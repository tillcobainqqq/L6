using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    abstract class FoodFactory
    {
        public abstract void addFoods();
    }

    class Food : FoodFactory
    {
        #region Fields
        List<string> foods = new List<string>();
        #endregion

        #region Properties
        public List<string> Foods
        {
            get { return foods; }
        }
        #endregion

        #region Methods
        public override void addFoods()
        {
            Console.Write("How many dishes did Gandalf eat: ");
            int n = int.Parse(Console.ReadLine());

            string dish = null;

            for(int i = 0; i < n; i++)
            {
                Console.Write("Dish: ");
                dish = Console.ReadLine();

                foods.Add(dish);
            }

        }
        #endregion
    }
}
