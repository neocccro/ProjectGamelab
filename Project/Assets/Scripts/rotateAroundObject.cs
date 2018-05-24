using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAroundObject : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objects;
    private float rotation;
    private float speed;

    // Use this for initialization
    void Start()
    {
        speed = 0.005f;
    }

    // Update is called once per frame
    void Update()
    {
        rotation += speed;
        for(int i = 0; i < objects.Length; i++)
        {
            objects[i].transform.position = new Vector3(Mathf.Cos(rotation + 2* Mathf.PI / objects.Length * i)*10, 0, Mathf.Sin(rotation + 2 * Mathf.PI / objects.Length * i) * 10);
        }
    }

    private void OnMouseDrag()
    {
        rotation += Input.GetAxis("Mouse X")/20;
    }
}
