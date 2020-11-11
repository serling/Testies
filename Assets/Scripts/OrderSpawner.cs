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

    public void AddOrder()
    {
        InstantiateOrder(); 
    }

    public void RemoveOrder(GameObject gameObject)
    {
        gameObject.SetActive(false); // alternatively: Destroy(gameObject);
    }

    public void RemoveRandomOrder()
    {
        int length = Orders.Count();

        int index = Random.Range(0, length);

        Orders.Items[index].gameObject.SetActive(false);
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
