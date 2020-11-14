﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using Testies.Models;

public class OrderSpawner : MonoBehaviour
{
    public OrderRuntimeSet PendingOrders;
    public MealRuntimeSet AvailableMeals;
    public GameObject OrderPrefab;

    private Vector3 getRandomPosition()
    {
        return new Vector3(Random.Range(-10f,10f), Random.Range(-10f,10f), 0);
    }

    private void InstantiateOrder() 
    {
        GameObject orderInstance = OrderPrefab;

        orderInstance.GetComponent<Order>().SetMeal(AvailableMeals.getRandom()); // Technicality: sets meal on prefab, not instance. Then clones. OK?

        Instantiate(orderInstance, getRandomPosition(), Quaternion.identity);
    }

    public void AddOrder()
    {
        InstantiateOrder(); 
    }

    [SerializeField]
    public void PrintOrder(Order order) 
    {
        Debug.Log(order);
    }

    public void RemoveOrder(GameObject gameObject)
    {
        // gameObject.SetActive(false); // alternatively: Destroy(gameObject);
    }

    public void RemoveRandomOrder()
    {
        int length = PendingOrders.Count();

        int index = Random.Range(0, length);

        PendingOrders.Items[index].gameObject.SetActive(false);
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
