using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAroundObject : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> objects;
    private float rotation;
    [SerializeField]
    private float width;
    [SerializeField]
    private float speed;
    [SerializeField]
    private SelectableObjectContainer selectableObjectContainer;

    private void Awake()
    {
        objects = new List<GameObject>();
    }
    // Update is called once per frame
    void Update()
    {
        rotation += speed;
        for(int i = 0; i < objects.Count; i++)
        {
            Vector3 tmp = new Vector3(Mathf.Cos(rotation + 2 * Mathf.PI / objects.Count * i) * width, 0, Mathf.Sin(rotation + 2 * Mathf.PI / objects.Count * i) * width);
            objects[i].transform.position = tmp * transform.localScale.x;
            objects[i].transform.eulerAngles = new Vector3(0, -rotation * 180 / Mathf.PI + selectableObjectContainer.FindMatchingDataWith(objects[i]).rotation - 360 / objects.Count * i, 0);
        }


        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Get movement of the finger since last frame
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Rotate object using X plane
            rotation += touchDeltaPosition.x/100;
        }
    }

    public void AddObjectToRotateList(GameObject obj)
    {
        objects.Add(obj);
    }
    /*
    private void OnMouseDrag()
    {
        rotation += Input.GetAxis("Mouse X")/20;
    }
    */
}
