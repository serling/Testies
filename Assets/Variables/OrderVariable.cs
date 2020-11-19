using UnityEngine;
using Testies.Models;

namespace Testies.Variables
{
    [CreateAssetMenu(menuName = "Variables/Order")]
    public class OrderVariable : ScriptableObject
    {   
        public Order Order;

        public void ResetOrder() {
            Order = null;
        }

        public void SetOrder(Order order)
        {
            Order = order;
        }

        public void SetOrder(OrderVariable order)
        {
            Order = order.Order;
        }
    }

}