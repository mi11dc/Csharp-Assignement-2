using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2.Models
{
    public class Pepper
    {
        public string Name { get; set; }
        public int Value { get; set; }

        /// <summary>
        /// Returns static names of every peppers from list and their values.
        /// </summary>
        /// <returns>List of peppers with name and Value</returns>
        public List<Pepper> GetPeppers()
        {
            return new List<Pepper>()
            {
                new Pepper() { Name = "Poblano", Value = 1500 },
                new Pepper() { Name = "Mirasol", Value = 6000 },
                new Pepper() { Name = "Serrano", Value = 15500 },
                new Pepper() { Name = "Cayenne", Value = 40000 },
                new Pepper() { Name = "Thai", Value = 75000 },
                new Pepper() { Name = "Habanero", Value = 125000 },
            };
        }
    }
}