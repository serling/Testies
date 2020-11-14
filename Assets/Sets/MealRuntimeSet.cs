using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Scripts;
using Testies.Models;

namespace Testies.Sets 
{
        [CreateAssetMenu(fileName = "New Meal Set", menuName = "Runtime Sets/Meals")]

    public class MealRuntimeSet : RuntimeSet<Meal> {}
}
