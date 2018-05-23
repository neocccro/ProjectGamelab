using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

    private float height;
    private float width;
    private float rotation;
    private float speed;

    // Use this for initialization
    void Start()
    {
        height = Random.Range(0.0f, 10.0f);
        width = Random.Range(0.0f, 10.0f);
    }
	
	// Update is called once per frame
	void Update()
    {
        rotation += speed / width;
        gameObject.transform.position = new Vector3(Mathf.Sin(rotation), Mathf.Cos(rotation), height);
	}
}
