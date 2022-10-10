using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodListDataBinding
{
    public class Foods
    {
        public static List<FoodClass> GetFoods()
        {
            return new List<FoodClass>()
            {
                new FoodClass()
                {
                    FoodName="Burger",
                    TypeFood=FoodType.FastFood,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\burger.jpg",
                    Price="$10"
                },
                new FoodClass()
                {
                    FoodName="Biryani",
                    TypeFood=FoodType.Meal,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\biryani.jpg",
                    Price="$30"
                },
                new FoodClass()
                {
                    FoodName="Crisps",
                    TypeFood=FoodType.Snacks,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\crisps.jpg",
                    Price="$5"
                }
            }.ToList();
        }
    }
}
