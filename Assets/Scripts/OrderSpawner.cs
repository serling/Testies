using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using Testies.Models;

public class OrderSpawner : MonoBehaviour
{
    public OrderRuntimeSet Orders;
    public GameObject OrderPrefab; 

    private Vector3 getRandomPosition()
    {
        return new Vector3(Random.Range(-10f,10f), Random.Range(-10f,10f), 0);
    }

    private void InstantiateOrder() 
    {
        Instantiate(OrderPrefab, getRandomPosition(), Quaternion.identity);
    }

    private void DestroyOrder() 
    {
        // Destroy();
    }

    public void AddOrder()
    {
        InstantiateOrder(); // params
    }

    public void RemoveOrder() 
    {
        Debug.Log("Removing Order soon...");
        // DestroyOrder();
    }

    void Start()
    {
        var orders = Orders.Count();

        for (int i = 0; i < orders; i++) 
        {
            InstantiateOrder();

        }
    }

    void Update()
    {
        
    }
}
