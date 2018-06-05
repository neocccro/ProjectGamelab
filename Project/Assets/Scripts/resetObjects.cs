using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetObjects : MonoBehaviour
{
    private delegateHandler _delegateHandler;

    private void Start()
    {
        _delegateHandler = GetComponent<delegateHandler>();
    }
    public void LoadByIndex(int sceneIndex)
    {
        _delegateHandler.objectBack();
        //SceneManager.LoadScene(sceneIndex);
    }
}
