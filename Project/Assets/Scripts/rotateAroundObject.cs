using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAroundObject : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objects;
    private float rotation;
    [SerializeField]
    private float width;
    [SerializeField]
    private float speed;

    // Update is called once per frame
    void Update()
    {
        rotation += speed;
        for(int i = 0; i < objects.Length; i++)
        {
            objects[i].transform.position = new Vector3(Mathf.Cos(rotation + 2* Mathf.PI / objects.Length * i)*width, 0, Mathf.Sin(rotation + 2 * Mathf.PI / objects.Length * i) * width);
        }


        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Get movement of the finger since last frame
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Rotate object using X plane
            rotation += touchDeltaPosition.x/100;
        }
    }
    /*
    private void OnMouseDrag()
    {
        rotation += Input.GetAxis("Mouse X")/20;
    }
    */
}
