using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textHandler : MonoBehaviour {

    [SerializeField] private Text textBox;
    [SerializeField] private Text textTitleBox;
    [SerializeField] private GameObject textPanel;
    [SerializeField] private Button button;
    [SerializeField] private delegateHandler delegat;


    void Start ()
    {
        delegat.objectToFront += changeText;
        delegat.objectBack += DisableCanvas;
    }
	void Update () {
		
	}

    public void changeText(SelectableObjectData data)
    {
        EnableCanvas();
        textBox.text = data.text;
        textTitleBox.text = data.name;
    }

    void DisableCanvas()
    {
        textBox.gameObject.SetActive(false);
        textTitleBox.gameObject.SetActive(false);
        textPanel.SetActive(false);
        button.gameObject.SetActive(false);
    }

    void EnableCanvas()
    {
        textBox.gameObject.SetActive(true);
        textTitleBox.gameObject.SetActive(true);
        textPanel.SetActive(true);
        button.gameObject.SetActive(true);
    }


}