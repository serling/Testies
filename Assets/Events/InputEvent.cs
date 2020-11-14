using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Events;
using Testies.Models;

namespace Testies.Events
{
    [CreateAssetMenu(fileName = "New InputEvent", menuName = "Events/Input Event (gameObject)")]
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
