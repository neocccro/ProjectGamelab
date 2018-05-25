using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            
            Plane plane = new Plane(Vector3.up, transform.position);
            float distance = 0; 
            if (plane.Raycast(ray, out distance))
            { 
                Vector3 pos = ray.GetPoint(distance); 
            }
        }
    }
}