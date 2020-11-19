using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using Testies.Models;

public class OrderSpawner : MonoBehaviour
{
    public OrderRuntimeSet PendingOrders;
    
    public GameObject OrderPrefab;

    private Vector3 getRandomPosition()
    {
        return new Vector3(Random.Range(-10f,10f), Random.Range(-10f,10f), 0);
    }

    private void InstantiateOrder() 
    {
        GameObject orderInstance = OrderPrefab;

        Instantiate(orderInstance, getRandomPosition(), Quaternion.identity);
    }

    public void AddOrder()
    {
        InstantiateOrder(); 
    }

    void Start()
    {
        var orders = PendingOrders.Count();

        for (int i = 0; i < orders; i++) 
        {
            InstantiateOrder();
        }
    }
}
