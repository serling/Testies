using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Testies.Models;

namespace Testies.Events
{
    public class InputEventListener : MonoBehaviour
    {
        public InputEvent Event;

        public InputUnityEvent Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(GameObject gameObject)
        {
            Response.Invoke(gameObject);
        }
        
    }
}
