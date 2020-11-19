using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Models;
using Testies.Variables;
using UnityEngine.UI;
public class ActiveOrderScript : MonoBehaviour
{
    public OrderVariable Order;
    public Text Text;

    public void SetText(Order order)
    {
        Debug.Log(order);
        // Text.text = Order.Label;
    }

}
