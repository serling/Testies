using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Testies.Models;

namespace Testies.Events
{
    [System.Serializable]
    public class OrderUnityEvent : UnityEvent<Order> {}
}
