using UnityEngine;
using Testies.Models;

namespace Testies.Variables
{
    [CreateAssetMenu(menuName = "Variables/Order")]
    public class OrderVariable : ScriptableObject
    {   
        public Order Value;

         public void SetValue(Order value)
        {
            Value = value;
        }

        public void SetValue(OrderVariable value)
        {
            Value = value.Value;
        }
    }

}