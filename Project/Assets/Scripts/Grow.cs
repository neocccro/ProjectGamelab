using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour {

    [SerializeField] private float time;
    [SerializeField] private Transform obj;
    private Vector3 originalSize;
    private float fraction;
    private float startTime;


    // Use this for initialization
    void Start()
    {
        originalSize = obj.localScale;
        startTime = Time.time;
    }
	
	// Update is called once per frame
	void Update()
    {
        fraction = (Time.time - startTime) / time;
        obj.localScale = Vector3.Lerp(new Vector3(0, 0, 0), originalSize, Mathf.Min(fraction,1));
	}

    public void Restart()
    {
        startTime = Time.time;
    }
}
