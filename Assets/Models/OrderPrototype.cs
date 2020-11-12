using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using Testies.Events;
using Testies.Steps;

namespace Testies.Models {

    public abstract class OrderPrototype : ScriptableObject
    {
        // public OrderRuntimeSet ActiveOrders;

        // public OrderRuntimeSet CompletedOrders;

        // public OrderEvent OnOrderCompleted;

        // private void OnEnable()
        // {
        //     ActiveOrders.Add(this);
        // }

        // private void OnDisable()
        // {
        //     ActiveOrders.Remove(this);

        //     CompletedOrders.Add(this);

        //     OnOrderCompleted.Raise(this);

        // }

    }
}
