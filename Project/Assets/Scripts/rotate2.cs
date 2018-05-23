using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate2 : MonoBehaviour
{
    private float height;
    private float width;
    private float rotation;
    private float speed;

    // Use this for initialization
    void Start()
    {
        speed = 0.2f;
        height = Random.Range(2.0f, 10.0f);
        width = height;
    }

    // Update is called once per frame
    void Update()
    {
        rotation += speed / width;
        gameObject.transform.position = new Vector3(Mathf.Sin(rotation) * width, height, Mathf.Cos(rotation) * width);
    }
}
