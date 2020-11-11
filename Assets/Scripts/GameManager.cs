using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Events;
using UnityEngine.Events;
using Testies.Sets;
using Testies.Models;

public class GameManager : MonoBehaviour
{

    public InputEvent onMouseClick;

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //TODO: extract this into event 
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                onMouseClick.Raise(hit.transform.gameObject);
            }
        }
        
    }


}
