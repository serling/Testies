using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Actions;

namespace Testies.Steps {
    
    [CreateAssetMenu(fileName = "Step", menuName = "Step", order = 0)]
    public class Step : ScriptableObject {   

        public List<Action> Actions;

        private bool isCompleted;

      }
}