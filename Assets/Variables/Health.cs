using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Testies.Variables
{
    public class Health : MonoBehaviour
    {
        public FloatVariable CurrentHealth;
        public FloatReference StartingHealth;
        public bool ResetHealth;

        private void Start()
        {
            if (ResetHealth) CurrentHealth.SetValue(StartingHealth);
        }
    }
}