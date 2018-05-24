using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour
{
    private Ray m_Ray;
    private RaycastHit m_RayCastHit;
    private Vector3 touchedFinger; 
    

    void Update()
    {
         for (var i = 0; i < Input.touchCount; ++i)
            {
              if (Input.GetTouch(i).phase == TouchPhase.Began)
              {            
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                    if (Physics.Raycast(ray))
                    {
                        Debug.Log("touchie");
                    }
   
              }
         }
    }
}