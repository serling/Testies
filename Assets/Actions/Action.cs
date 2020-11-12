using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Testies.Actions {
    [CreateAssetMenu(fileName = "Action", menuName = "Action", order = 0)]
    public class Action : ScriptableObject {
        public string Title;
        private bool isCompleted;
    }
}