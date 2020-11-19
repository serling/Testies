using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Testies.Models;

namespace Testies.Events
{
    public class OrderEventListener : MonoBehaviour
    {
        public OrderEvent Event;

        public OrderUnityEvent Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(Order order) 
        {
            Response.Invoke(order);
        }
        
    }
}
