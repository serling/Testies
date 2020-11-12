using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Variables;
using UnityEngine.Events;

namespace Testies.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public FloatReference Health;

        public UnityEvent DeathEvent;

        private bool IsDead = false;

        void Start()
        {
            if (Health.Value == 0) DeathEvent.Invoke();
        }

        void Update()
        {
            if (IsDead) return;

            if (Health.Value == 0) DeathEvent.Invoke();
        }
    }
}