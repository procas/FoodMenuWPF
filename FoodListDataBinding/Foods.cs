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
                    Price="$10",
                    Description="Burger is a nice and tasty fastfood made from bun bread, meat, cheese and veggies! 😛"
                },
                new FoodClass()
                {
                    FoodName="Biryani",
                    TypeFood=FoodType.Meal,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\biryani.jpg",
                    Price="$112",
                    Description="Biryani is rice and meat and occasionally potatos mixed with essence and saffron. It is very popular dish in South Asia. 🥘"
                    
                },
                new FoodClass()
                {
                    FoodName="Pasta",
                    TypeFood=FoodType.Meal,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\pasta.png",
                    Price="$55",
                    Description="Pasta is an Italian origin cuisine that is loved and desired all over the world! Nothing like a dainty little dish of pasta for any meal of the day. 🍝"
                },
                new FoodClass()
                {
                    FoodName="Crisps",
                    TypeFood=FoodType.Snacks,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\crisps.jpg",
                    Price="$5",
                    Description="Crisps are basically fried and dried potatoes that go really well with a movie night! 🍟"
                },
                new FoodClass()
                {
                    FoodName="Fruit Juice",
                    TypeFood=FoodType.Beverage,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\juice.jpg",
                    Price="$12",
                    Description="Refreshing fruit juice to liven your spirits after a long and tiresome day! 🥤"
                },
                new FoodClass()
                {
                    FoodName="Icecream",
                    TypeFood=FoodType.Dessert,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\icecream.png",
                    Price="$5",
                    Description="What a way to put a perfect ending to a perfect dinner date! 🍨"
                },
                new FoodClass()
                {
                    FoodName="Pizza",
                    TypeFood=FoodType.FastFood,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\pizza.jpg",
                    Price="$40",
                    Description="Pizza is one of the tastiest fastfood out there! Pro's Restaurant brings you your pizza with a special twist - customization! 🍕"
                },
                new FoodClass()
                {
                    FoodName="Hotdog",
                    TypeFood=FoodType.FastFood,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\hotdog.png",
                    Price="$10",
                    Description="Hotdog is especially popular for its easy to carry characteristic, have it now or take it for your journey. Happy hotdogging! 🌭"
                }
                ,
                new FoodClass()
                {
                    FoodName="Chicken Curry",
                    TypeFood=FoodType.Meal,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\chicken.png",
                    Price="$5",
                    Description="Specially made chicken curry with butter, curry leaves and many more delicious flavours! Take a bite and we guarantee you cannot stop! 🍗"
                }
                ,
                new FoodClass()
                {
                    FoodName="Masala Tea",
                    TypeFood=FoodType.Beverage,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\masalatea.jpg",
                    Price="$15",
                    Description="What can be any better than a side of nice masala chai to go with any starter! ☕"
                }
                ,
                new FoodClass()
                {
                    FoodName="Burrito",
                    TypeFood=FoodType.Snacks,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\burrito.png",
                    Price="$8",
                    Description="A heavenly combo of freshly made tortilla, veggies and mayo to please your appetite! 🌯"
                }
                ,
                new FoodClass()
                {
                    FoodName="Icecream",
                    TypeFood=FoodType.Dessert,
                    ImageSource="C:\\Users\\Proma_Mukherjee\\source\\repos\\FoodListDataBinding\\FoodListDataBinding\\Images\\icecream.png",
                    Price="$5",
                    Description="What a way to put a perfect ending to a perfect dinner date! 🍨"
                }
            }.ToList();
        }
    }
}
