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
    }
}