using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Actions;

namespace Testies.Steps {
    
    [CreateAssetMenu(fileName = "New Step", menuName = "Models/Step")]
    public class Step : ScriptableObject {   

        public List<Action> Actions;

        private bool isCompleted;

      }
}