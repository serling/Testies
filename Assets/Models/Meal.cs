﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using Testies.Events;
using Testies.Steps;

namespace Testies.Models {

    [CreateAssetMenu(fileName = "New Meal", menuName = "Models/Meal")]
    public class Meal : ScriptableObject
    {
        public string Name;

        public List<Step> Steps;

        public Meal(string name)
        {
            Name = name;
        }

    }
}
