using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    public Button button;
    public Text buttonText;


    private GameController gameController;

    public void SetSpace()
    {
        buttonText.text = gameController.GetPlayerSide();
        string pSide = gameController.GetPlayerSide();
        //Debug.Log(pSide);
        if (pSide == "X")
        {
            GetComponent<Image>().color = Color.red;
        }
        else
        {
            GetComponent<Image>().color = Color.blue;
        }
        //TODO: figure out new code that functions as follows:  buttonColor.color = gameController.GetPlayerColor();
        button.interactable = false; //This line makes the button deactivate so it can no longer be selected or changed. 
        gameController.EndTurn(); //This line calls the method in the gameController class to check for 3 in a row
    }
    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }
}