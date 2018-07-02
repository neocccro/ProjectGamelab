using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delegateHandler : MonoBehaviour {

    public delegate void ObjectToFront(GameObject gameObject);
    public ObjectToFront objectToFront;

    public delegate void ObjectBack();
    public ObjectBack objectBack;

    private GameObject objectToMove;
    public Transform startMarker;
    public Transform endMarker;
    public Transform origin;
    private float startTime;
    private Coroutine move;
    [SerializeField] private float time;
    private GameObject obj;

    private void Start()
    {
        objectToFront += startMove;
        objectBack += stopMove;
        objectBack += KillAllChildren;
        objectToFront += DisableWheel;
        objectBack += EnableWheel;
        endMarker = GameObject.FindGameObjectWithTag("endMarker").transform;
    }

    void startMove(GameObject gameObject)
    {
        startTime = Time.time;
        obj = Instantiate(gameObject.gameObject, gameObject.transform);
        obj.transform.parent = endMarker;
        obj.AddComponent<rotateObject>();
        obj.transform.LookAt(Camera.main.transform);

        move = StartCoroutine(updateMove());
    }

    IEnumerator updateMove()
    {
        while(true)
        {
            float fraction = (Time.time - startTime) / time;
            obj.transform.position = Vector3.Lerp(gameObject.transform.position, endMarker.position, Mathf.Min(fraction, 1));
            yield return null;
        }
    }

    void stopMove()
    {
        StopCoroutine(move);
    }

    public void backButton()
    {
        objectBack();
    }

    public void KillAllChildren()
    {
        foreach (Transform child in endMarker)
        {
            Destroy(child.gameObject);
        }
    }

    void DisableWheel(GameObject gameObject)
    {
        origin.gameObject.SetActive(false);
    }

    void EnableWheel()
    {
        origin.gameObject.SetActive(true);
    }
}
