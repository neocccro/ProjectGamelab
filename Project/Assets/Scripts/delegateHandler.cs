using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delegateHandler : MonoBehaviour {

    public delegate void ObjectToFront(string text, string title);
    public ObjectToFront objectToFront;

    public delegate void ObjectBack();
    public ObjectBack objectBack;
    
    public Transform startMarker;
    public Transform endMarker;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;

    private void Start()
    {
        objectToFront += startMove;
    }

    void startMove(string a, string b)
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
    }
}
