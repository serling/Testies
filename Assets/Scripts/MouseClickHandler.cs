using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testies.Events;

public class MouseClickHandler : MonoBehaviour
{
    public InputEvent onMouseClick;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
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
