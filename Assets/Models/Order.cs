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

        public List<Step> Steps;
        
        public string Title = "Hamburger";

        public Order() {}

        public Order(string title) {
            Title = title;
        }

        private void OnEnable()
        {
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
