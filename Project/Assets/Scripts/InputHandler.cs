using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour
{
    void start() { print("entro"); }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, 100))
            print("yolo");
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                if (Physics.Raycast(ray))
                {
                    transform.Rotate(Vector3.up / 8, Space.World);
                }

            }
        }
    }
}