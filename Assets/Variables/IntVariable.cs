using UnityEngine;

namespace Testies.Variables
{
    [CreateAssetMenu(menuName = "Variables/Integer")]
    public class IntVariable : ScriptableObject
    {   
        public int Value;

         public void SetValue(int value)
        {
            Value = value;
        }

        public void SetValue(IntVariable value)
        {
            Value = value.Value;
        }
    }

}