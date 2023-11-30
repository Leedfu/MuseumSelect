using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToFocus : MonoBehaviour
{
   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;

                Camera.main.transform.position = clickedObject.transform.position - Camera.main.transform.forward * 20f;

                Camera.main.transform.LookAt(clickedObject.transform.position);
            }
        }
    }
}
