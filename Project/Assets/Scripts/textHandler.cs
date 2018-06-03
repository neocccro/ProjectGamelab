using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textHandler : MonoBehaviour {

    [SerializeField] private Text textBox;
    [SerializeField] private Text textTitleBox;
    [SerializeField] private GameObject textPanel;
    [SerializeField] private delegateHandler delegat;


    // Use this for initialization
    void Start ()
    {
        delegat.objectToFront += changeText;
        delegat.objectBack += DisableCanvas;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeText(string text, string title)
    {
        EnableCanvas();
        textBox.text = text;
        textTitleBox.text = title;
    }

    void DisableCanvas()
    {
        textBox.gameObject.SetActive(false);
        textTitleBox.gameObject.SetActive(false);
        textPanel.SetActive(false);
    }

    void EnableCanvas()
    {
        textBox.gameObject.SetActive(true);
        textTitleBox.gameObject.SetActive(true);
        textPanel.SetActive(true);
    }


}