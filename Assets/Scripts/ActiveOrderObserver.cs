using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Models;
using Testies.Variables;
using UnityEngine.UI;

public class ActiveOrderObserver : MonoBehaviour
{
    public Text Text;

    private const string noneText = "None";

    public void UpdateText(Order order)
    {
        Text.text = order.Label;
    }

    public void ResetText()
    {
        Text.text = noneText;
    }

    private void OnEnable()
    {
         ResetText();
    }
}
