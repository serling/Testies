using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Models;

namespace Testies.Events
{
    [CreateAssetMenu(fileName = "New OrderEvent", menuName = "Events/Order Event")]
    public class OrderEvent: ScriptableObject 
    {
        private readonly List<OrderEventListener> eventListeners = new List<OrderEventListener>();

        public void Raise(Order order)
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--) eventListeners[i].OnEventRaised(order);
        }

        public void RegisterListener(OrderEventListener listener) {
            if (!eventListeners.Contains(listener)) eventListeners.Add(listener);
        }
        public void UnregisterListener(OrderEventListener listener) {
            if (eventListeners.Contains(listener)) eventListeners.Remove(listener);
        }
       
    }
}
