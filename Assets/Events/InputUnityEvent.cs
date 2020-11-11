using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Testies.Models;

namespace Testies.Events
{
    [System.Serializable]
    public class InputUnityEvent : UnityEvent<GameObject> {}
}