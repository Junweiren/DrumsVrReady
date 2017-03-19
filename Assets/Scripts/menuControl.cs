using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class menuControl : MonoBehaviour {

    public Canvas endMenu;
    public Button start;
    public Button exit;
    public Button restart;
    // Use this for initialization
    void Start () {
        endMenu = endMenu.GetComponent<Canvas>();
        start = start.GetComponent<Button>();
        exit = exit.GetComponent<Button>();
        restart = restart.GetComponent<Button>();
        endMenu.enabled = false;
        
    }

    public void exitTraining()
    {
        Application.Quit();
    }

    public void startTraining()
    {
        Debug.Log("start the training");
    }

    public void restartTraining()
    {
        Debug.Log("restart the training");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
