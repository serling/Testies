using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;

namespace Testies.Models {

public class Order : ScriptableObject
    {
        // public OrderRuntimeSet OrderSet;
        public string Title;

        public Order() {}

        public Order(string title) {
            Title = title;
        }

        // private void OnEnable()
        // {
        //     OrderSet.Add(this);
        // }

        // private void OnDisable()
        // {
        //     OrderSet.Remove(this);
        // }
    }
}
