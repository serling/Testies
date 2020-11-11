using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Events;
using UnityEngine.Events;
using Testies.Sets;

public class GameManager : MonoBehaviour
{

    public OrderRuntimeSet Orders;

    void Start()
    {
        Debug.Log(Orders.Count());
    }

    void Update()
    {
        
    }
}
