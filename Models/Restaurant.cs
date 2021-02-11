using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Morris_Isaac_Homework4.Models
{
    public class Restaurant
    {
        [Required]
        public int Rank { get; set; }
        [Required]
        public string Name { get; set; }
        public string FavoriteDish { get; set; } = "It's all tasty!";
        [Required]
        public string Address { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        public string? Phone { get; set; }
        public string Website { get; set; } = "Coming soon";

        public static void addRestaurant(Restaurant restaurant)
        {
            Restaurant r = new Restaurant()
            {
                Rank = restaurant.Rank,
                Name = restaurant.Name,
                FavoriteDish = restaurant.FavoriteDish,
                Address = restaurant.Address,
                Phone = restaurant.Phone,
                Website = restaurant.Website
            };
        }

        public static Restaurant[] loadRestaurants()
        {
            Restaurant r1 = new Restaurant()
            {
                Rank = 1,
                Name = "Brick Oven",
                FavoriteDish = "Pepperoni Pizza",
                Address = "864 N 800 W",
                Phone = "999-999-9999",
                Website = "www.brickoven.com"
            };

            Restaurant r2 = new Restaurant()
            {
                Rank = 2,
                Name = "Sensuous Sandwich",
                FavoriteDish = "Classic BLT",
                Address = "846 N 800 W",
                Phone = "999-999-9999",
                Website = "www.senswich.com"
            };

            Restaurant r3 = new Restaurant()
            {
                Rank = 3,
                Name = "Nico's Pizza",
                FavoriteDish = "6 Cheeses",
                Address = "648 N 800 W",
                Phone = "999-999-9999",
                Website = "www.nicospizza.com"
            };

            Restaurant r4 = new Restaurant()
            {
                Rank = 4,
                Name = "Penguin Brothers",
                FavoriteDish = "Strawberry Macaroon",
                Address = "684 N 800 W",
                Phone = "999-999-9999",
                Website = "www.pengbros.com"
            };

            Restaurant r5 = new Restaurant()
            {
                Rank = 5,
                Name = "Los Hermanos",
                Address = "468 N 800 W",
                Phone = "999-999-9999",
                Website = "www.loshermanitos.com"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
