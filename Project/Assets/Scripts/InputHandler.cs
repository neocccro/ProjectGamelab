using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour
{
<<<<<<< HEAD

    void start() { print("entro"); }

    public SelectableObjectContainer container;
=======
    [SerializeField] private SelectableObjectContainer container;
    [SerializeField] private delegateHandler delegat;
>>>>>>> 879b9e5e2e0ee58adb9c1f24bc3c2db212e0165c
    /*
    public enum InputType
    {
        Mouse,
        Touch
    }
    public InputType inputType;
    */
<<<<<<< HEAD

=======
>>>>>>> 879b9e5e2e0ee58adb9c1f24bc3c2db212e0165c
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
<<<<<<< HEAD

=======
>>>>>>> 879b9e5e2e0ee58adb9c1f24bc3c2db212e0165c
}