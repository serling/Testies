using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Sets;
using Testies.Models;
using Testies.OrderTypes;

public class OrderSpawner : MonoBehaviour
{
    public OrderRuntimeSet ActiveOrders;
    public GameObject OrderPrefab;

    private Vector3 getRandomPosition()
    {
        return new Vector3(Random.Range(-10f,10f), Random.Range(-10f,10f), 0);
    }

    private void InstantiateOrder(string text) 
    {
        GameObject orderInstance = Instantiate(OrderPrefab, getRandomPosition(), Quaternion.identity);

        // orderInstance.GetComponent<Order>().SetTitle("Blargh");
        
    }

    public void AddOrder()
    {
        InstantiateOrder("from add"); 
    }

    public void RemoveOrder(GameObject gameObject)
    {
        gameObject.SetActive(false); // alternatively: Destroy(gameObject);
    }

    public void RemoveRandomOrder()
    {
        int length = ActiveOrders.Count();

        int index = Random.Range(0, length);

        ActiveOrders.Items[index].gameObject.SetActive(false);
    }

    void Start()
    {
        var orders = ActiveOrders.Count();

        for (int i = 0; i < orders; i++) 
        {
            InstantiateOrder("from start");
        }
    }

    void Update()
    {
        
    }
}
