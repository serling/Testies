using UnityEngine;
using System;
using Testies.Models;

namespace Testies.Variables
{
    [Serializable]
    public class OrderReference
    {   
        public OrderReference Variable;

        public Order Value 
        {
            get { return Variable.Value; }
        }

        //  public static implicit operator Order(OrderReference reference)
        //     {
        //         return reference.Value;
        //     }
    }

}