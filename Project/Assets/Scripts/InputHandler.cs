using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private SelectableObjectContainer container;
    [SerializeField] private delegateHandler delegat;
    /*
    public enum InputType
    {
        Mouse,
        Touch
    }
    public InputType inputType;
    */
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
                Click(Input.GetTouch(i).position);
            }
        }
    }

    private void HandleMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Click(Input.mousePosition);
        }
    }

    private void Click(Vector3 pos)
    {
        Ray ray = Camera.main.ScreenPointToRay(pos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            var data = container.FindMatchingDataWith(hit.transform.gameObject);
            print(data);
            print(data.text);
            delegat.objectToFront(hit.transform.gameObject, data);
        }

    }
}