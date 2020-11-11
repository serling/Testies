using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;

namespace Testies.Models {

    public class Order : MonoBehaviour
    {
        public OrderRuntimeSet OrderSet;
        
        public string Title = "Hamburger";

        public Order() {}

        public Order(string title) {
            Title = title;
        }

        private void OnEnable()
        {
            OrderSet.Add(this);
        }

        private void OnDisable()
        {
            OrderSet.Remove(this);
        }

        private void Update() 
        {
            
        }
    }
}
