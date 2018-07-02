using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class SelectableObjectData : ScriptableObject
{
    public string name;
    public GameObject gameObject;
    public string text;
    public float size;
    public float rotation;
}
