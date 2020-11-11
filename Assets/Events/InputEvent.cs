using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Events;
using UnityEngine.Events;
using Testies.Sets;
using Testies.Models;

namespace Testies.Events
{
    [CreateAssetMenu]
    public class InputEvent : ScriptableObject
    {
        private readonly List<InputEventListener> eventListeners = new List<InputEventListener>();

        public void Raise(GameObject gameObject)
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--) eventListeners[i].OnEventRaised(gameObject);
        }

        public void RegisterListener(InputEventListener listener) {
            if (!eventListeners.Contains(listener)) eventListeners.Add(listener);
        }
        public void UnregisterListener(InputEventListener listener) {
            if (eventListeners.Contains(listener)) eventListeners.Remove(listener);
        }
    }
}
