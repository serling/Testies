using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using Testies.Events;
using Testies.Steps;
using Testies.Models;

namespace Testies.Scripts {

    public class OrderScript : MonoBehaviour
    {
        public MealRuntimeSet AvailableMeals;
        public OrderRuntimeSet PendingOrders;

        public OrderRuntimeSet CompletedOrders;

        public OrderEvent OnOrderCompleted;
        private Order order;

        private void OnMouseUp() {
            OnOrderCompleted.Raise(order);

            order.gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            order = this.gameObject.AddComponent<Order>();

            order.SetMeal(AvailableMeals.getRandom());

            PendingOrders.Add(order);
        }

        private void OnDisable()
        {
            PendingOrders.Remove(order);

            CompletedOrders.Add(order);

        }

       

    }
}
