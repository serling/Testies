using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using UnityEngine.UI;

public class OrdersObserver : MonoBehaviour
{
    public OrderRuntimeSet Orders;

    public Text Text;

    private int previousCount = -1;

    public void UpdateText()
    {
        Text.text = Orders.Count().ToString();
    }

    private void OnEnable()
    {
        UpdateText();
    }

    private void Update()
    {
        if (previousCount != Orders.Count())
        {
            UpdateText();

            previousCount = Orders.Count();
        }
    }

    
}
