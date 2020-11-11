using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;

public class Order : MonoBehaviour
{
    public OrderRuntimeSet OrderSet;
    public string title;

    private void OnEnable()
    {
        OrderSet.Add(this);
    }

    private void OnDisable()
    {
        OrderSet.Remove(this);
    }
}
