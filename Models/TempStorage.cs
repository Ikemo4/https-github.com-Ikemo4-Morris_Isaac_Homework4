using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Morris_Isaac_Homework4.Models
{
    public class TempStorage
    {
        private static List<Restaurant> restaurants = new List<Restaurant>();
        public static IEnumerable<Restaurant> Restaurants => restaurants;
        public static void AddRestaurant(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}
