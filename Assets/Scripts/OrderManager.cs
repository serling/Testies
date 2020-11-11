using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using Testies.Models;

namespace Testies.Scripts
{
    public class OrderManager : MonoBehaviour
    {
        public OrderRuntimeSet Orders;

        public void AddOrder() //TODO: take param
        {
            var order = ScriptableObject.CreateInstance<Order>();
            order.Title = "Hamburger";
            
            Orders.Add(order);

            Debug.Log("Added " + order.Title + ". Total number of Orders:" + Orders.Count());
        }

        public void RemoveOrder() 
        {
            Debug.Log("Removing Order...");
            // Orders.Remove()
        }
        void Start()
        {
            Debug.Log("Order Manager Loaded. Orders:" + Orders.Count());
        }

        void Update()
        {
            // Debug.Log("Order Manager Loaded. Number of Orders:" + Orders.Count());
            
        }
    }
}
