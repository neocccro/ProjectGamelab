using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour
{
    public SelectableObjectContainer container;

    public enum InputType
    {
        Mouse,
        Touch
    }
    public InputType inputType;

    void Update()
    {
        switch(inputType)
        {
            case InputType.Mouse:
                HandleMouseInput();
                break;
            case InputType.Touch:
                HandleTouchInput();
                break;
        }
    }

    private void HandleTouchInput()
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
                    Debug.Log("dead");
                }

            }
        }
    }

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
}