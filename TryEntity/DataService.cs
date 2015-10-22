using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryEntity
{
    internal class DataService
    {
        public static void Load()
        {
            // Database context
            //
            try_entityEntities context = new try_entityEntities();
            var mealCourseGrouping = from meal in context.meals
                               group meal by new {  MealName = meal.meal_name,
                                                    CourseName = meal.course_name }
                               into mealCourse
                               orderby mealCourse.Key.MealName
                               select mealCourse;
            if (mealCourseGrouping != null)
            {
                foreach (var meal in mealCourseGrouping)
                {
                    foreach (var course in meal)
                    {
                        printMealCourseItem(course.meal_name, course.course_name, course.item);
                    }
                }
            }
        }


        /* Output is
            Meal:southern_dinner Course:appetizer Item:pickles
            Meal:southern_dinner Course:dessert Item:pie
            Meal:southern_dinner Course:main Item:steak
            Meal:southern_dinner Course:salad Item:spinach
            Meal:veggie_lunch Course:appetizer Item:carrots
            Meal:veggie_lunch Course:dessert Item:strawberries
            Meal:veggie_lunch Course:main Item:tofu burrito
            Meal:veggie_lunch Course:salad Item:fruit
         */
        static void printMealCourseItem(string meal, string course, string item)
        {
            var tuple = string.Format("Meal:{0} Course:{1} Item:{2}", meal, course, item);
            Console.WriteLine(tuple);
        }
    }
}
