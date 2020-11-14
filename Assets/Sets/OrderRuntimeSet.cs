using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Scripts;
using Testies.Models;

namespace Testies.Sets 
{
            [CreateAssetMenu(fileName = "New Order Set", menuName = "Runtime Sets/Orders")]

    public class OrderRuntimeSet : RuntimeSet<Order> {}
}
