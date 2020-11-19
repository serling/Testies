using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using Testies.Events;

namespace Testies.Models {

    public class Order : MonoBehaviour 
    {
        public Meal Meal { get; set; }
        public string Label;

        public Order() {
            Label = "Naffin!";
        }

        public Order(Meal meal) {
            Meal = meal;
            Label = meal.Name;
        }

        public void SetMeal(Meal meal)
        {
            Meal = meal;
            Label = meal.Name;
        }

    }
}
