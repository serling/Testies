using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Models;
using Testies.Variables;
using UnityEngine.UI;

public class ActiveOrderObserver : MonoBehaviour
{
    public Text Text;

    public void UpdateText(Order order)
    {
        Text.text = order.Label;
    }

    private void OnEnable()
    {
         Text.text = "None";
    }



}
