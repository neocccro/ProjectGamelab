using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableObjectContainer : MonoBehaviour
{
    public SelectableObjectData[] objects;

    private rotateAroundObject rotator;

    private void Awake()
    {
        rotator = GetComponent<rotateAroundObject>();

        foreach(var data in objects)
        {
            InstantiateObject(data);
        }
    }

    private void InstantiateObject(SelectableObjectData data)
    {
        GameObject obj = Instantiate(data.gameObject);
        var col = obj.AddComponent<SphereCollider>();

        obj.name = data.name;
        col.radius = 2.0f;
        obj.transform.SetParent(transform);
        obj.transform.localScale = Vector3.one;

        if(data.name == "Krant")
        {
            obj.transform.localScale = new Vector3(4,4,4);
            col.radius = 0.5f;
        }

        rotator.AddObjectToRotateList(obj);
    }

    public SelectableObjectData FindMatchingDataWith(GameObject gameObject)
    {
        foreach(var dataItem in objects)
        {
            if (dataItem.name == gameObject.name)
            {
                return dataItem;
            }
        }
        return null;
    }
}
