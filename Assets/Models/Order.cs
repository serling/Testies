using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using Testies.Events;
using Testies.Steps;

namespace Testies.Models {

    public class Order : MonoBehaviour
    {
        public OrderRuntimeSet ActiveOrders;

        public OrderRuntimeSet CompletedOrders;

        public OrderEvent OnOrderCompleted;

        public string label;

        // public OrderEvent OnOrderStart;

        // on evnet: use a new canvas, populate meal + logic

        public Meal Meal;

        public void SetMeal(Meal meal)
        {
            Meal = meal;
            
            label = Meal.Name;
        }
        
        private void OnEnable()
        {
            label = Meal.Name;

            ActiveOrders.Add(this);
        }

        private void OnDisable()
        {
            ActiveOrders.Remove(this);

            CompletedOrders.Add(this);

            OnOrderCompleted.Raise(this);

        }

    }
}
