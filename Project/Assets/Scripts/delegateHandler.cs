using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delegateHandler : MonoBehaviour {

    public delegate void ObjectToFront(SelectableObjectData data);
    public ObjectToFront objectToFront;

    public delegate void ObjectBack();
    public ObjectBack objectBack;

    private GameObject objectToMove;
    public Transform endMarker;
    public Transform origin;

    private void Start()
    {
        objectToFront += startMove;
        objectBack += killAllChildren;
        objectToFront += DisableWheel;
        objectBack += EnableWheel;
        endMarker = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    void startMove(SelectableObjectData data)
    {
        GameObject egh = Instantiate(data.gameObject, endMarker);
        egh.transform.parent = endMarker;
        egh.AddComponent<rotateObject>();
    }

    public void backButton()
    {
        objectBack();
    }

    public void killAllChildren()
    {
        foreach (Transform child in endMarker)
        {
            Destroy(child.gameObject);
        }
    }

    void DisableWheel(SelectableObjectData data)
    {
        foreach (Transform child in origin)
        {
            child.gameObject.SetActive(false);
        }
    }

    void EnableWheel()
    {
        foreach (Transform child in origin)
        {
            child.gameObject.SetActive(true);
        }
    }
}
