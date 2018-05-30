using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textHandler : MonoBehaviour {

    [SerializeField]private Text textBox;
    [SerializeField] private GameObject Canvas;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeText(string text)
    {
        //change text
    }

    void DisableCanvas()
    {
        textBox.gameObject.SetActive(false);
        Canvas.SetActive(false);
    }


}