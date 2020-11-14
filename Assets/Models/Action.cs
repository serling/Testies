using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Testies.Actions {
    [CreateAssetMenu(fileName = "New Action", menuName = "Models/Action")]
    public class Action : ScriptableObject {
        public string Title;
        private bool isCompleted;
    }
}