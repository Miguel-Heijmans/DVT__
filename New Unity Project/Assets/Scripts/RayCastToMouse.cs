using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastToMouse : MonoBehaviour
{

     RaycastHit hit;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
        
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            if (Physics.Raycast (ray, out hit, 500)) {
                Debug.Log (hit.transform.name);
                Debug.Log ("hit");
                Debug.DrawRay (start: ray.origin, dir: ray.direction*100, Color.green);
            
            
            }
        }

        
    }
}
