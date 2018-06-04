using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delegateHandler : MonoBehaviour {

    public delegate void ObjectToFront(GameObject obj, SelectableObjectData data);
    public ObjectToFront objectToFront;

    public delegate void ObjectBack();
    public ObjectBack objectBack;
    
    public Vector3 startMarker;
    public Transform endMarker;
    public float timeNeeded = 1.0F;
    private float startTime;
    private float journeyLength;

    private void Start()
    {
        objectToFront += startMove;
    }

    void startMove(GameObject obj, SelectableObjectData data)
    {
        startMarker = obj.transform.position;
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker, endMarker.position);
    }
    void Update()
    {
        float timeCovered = Time.time - startTime;
        transform.position = Vector3.Lerp(startMarker, endMarker.position, Mathf.Min(timeCovered / timeNeeded, 1.0f));
    }
}
