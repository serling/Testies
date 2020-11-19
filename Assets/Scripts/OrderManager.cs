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
            Debug.Log("Logging order: " + order.Label);
        }

        public void CompleteOrder(Order order)
        {
            Debug.Log("Completing order: " + order.Label);
            
        }

        public void ActivateOrder(Order order)
        {
            Debug.Log("handling order: " + order.Label);
            
        }

        public void RemoveOrder(Order order)
        {
            Debug.Log("Removing order: " + order.Label);

        }

        public void RemoveRandomOrder()
        {
            int length = PendingOrders.Count();

            int index = Random.Range(0, length);

            PendingOrders.Items[index].gameObject.SetActive(false);

        }

    }
}
