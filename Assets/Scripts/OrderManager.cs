using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using Testies.Models;

namespace Testies.Scripts
{
    public class OrderManager : MonoBehaviour
    {
        public OrderRuntimeSet PendingOrders;

        public void LogOrder(Order order)
        {
            Debug.Log("Order label: " + order.Label);
        }

        public void CompleteOrder(Order order)
        {
            Debug.Log("Order completed: " + order.Label);
            
            // order.gameObject.SetActive(false);
        }

        public void RemoveOrder(Order order)
        {
            Debug.Log("just removing" + order.Label);

            // order.gameObject.SetActive(false);
        }

        public void RemoveRandomOrder()
        {
            int length = PendingOrders.Count();

            int index = Random.Range(0, length);

            PendingOrders.Items[index].gameObject.SetActive(false);

        }

    }
}
