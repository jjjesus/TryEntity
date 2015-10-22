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
            var mealGrouping = from meal in context.meals
                               group meal by new {  MealName = meal.meal_name,
                                                    CourseName = meal.course_name }
                               into mealCourse
                               orderby mealCourse.Key.MealName
                               select mealCourse;
            if (mealGrouping != null)
            {
                foreach (var meal in mealGrouping)
                {
                    var tuple = string.Format("Meal:{0} Course:{1}", meal.Key.MealName, meal.Key.CourseName);
                    Console.WriteLine(tuple);
                    foreach (var course in meal)
                    {
                        Console.WriteLine("  {0}", course.item);
                    }
                }
            }
        }
    }
}
