using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour
{
<<<<<<< HEAD
    void start() { print("entro"); }
=======
    public SelectableObjectContainer container;
    /*
    public enum InputType
    {
        Mouse,
        Touch
    }
    public InputType inputType;
    */
>>>>>>> 07d7158cf1dda1b873f95d93aa5b290452f9b387
    void Update()
    {
        switch(SystemInfo.deviceType)
        {
            case DeviceType.Desktop:
                HandleMouseInput();
                break;
            case DeviceType.Handheld:
                HandleTouchInput();
                break;
        }
    }

    private void HandleTouchInput()
    {
        for (var i = 0; i < Input.touchCount; ++i) // why the for loop, do we need multiple fingers?
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                if (Physics.Raycast(ray))
                {
                    Debug.Log("dead");
                }

            }
        }
    }
<<<<<<< HEAD
=======

    private void HandleMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                var data = container.FindMatchingDataWith(hit.transform.gameObject);
                print(data.text);
            }
        }
    }
>>>>>>> 07d7158cf1dda1b873f95d93aa5b290452f9b387
}