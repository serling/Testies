using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using Testies.Events;
using Testies.Steps;
using Testies.Models;
using Testies.Variables;

namespace Testies.Scripts {

    public class OrderScript : MonoBehaviour
    {
        public MealRuntimeSet AvailableMeals;
        public OrderRuntimeSet PendingOrders;

        public OrderVariable ActiveOrder;
        public OrderRuntimeSet CompletedOrders;

        public OrderEvent OnActivateOrder;
        public OrderEvent OnOrderCompleted;
        private Order order;

        private void OnMouseUp() {
            if (ActiveOrder.Order != order) {
                handleOrder();
            } else {
                completeOrder();
            }
        }

        private void completeOrder()
        {
            OnOrderCompleted.Raise(order);
            
            order.gameObject.SetActive(false);
        }


        private void handleOrder()
        {
            ActiveOrder.SetOrder(order);

            PendingOrders.Remove(order);

            OnActivateOrder.Raise(order);
        }

        private void OnEnable()
        {
            order = this.gameObject.AddComponent<Order>();

            order.SetMeal(AvailableMeals.getRandom());

            PendingOrders.Add(order);
        }

        private void OnDisable()
        {
            CompletedOrders.Add(order);

        }


       

    }
}
