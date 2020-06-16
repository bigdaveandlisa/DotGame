using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text[] buttonList; //This is a text array where each the text for each element is either X or O
    public string playerSide; //This is a string and is either X or O
    private Color playerColor;

    void Awake()
    {
        SetGameControllerReferenceOnButtons();
        playerSide = "X";  //This sets X as player 1
        playerColor = Color.red;
    }
    void SetGameControllerReferenceOnButtons()
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);  //This is calling on the gridSpace class to set up the buttonList array?
            //It appears to be matching up the button list array with the 9 buttons
        }

    }
    public string GetPlayerSide() //this is just getting the playerSide value from the GridSpace class 
    {
        return playerSide;
    }

    public Color GetPlayerColor()
    {
        return playerColor;
    }

    public void EndTurn() // This section looks for 3 X's or 3 O's, the row, column and diagonal are hard coded. 
    {
        //if (buttonList[0].text == playerSide && buttonList[1].text == playerSide && buttonList[2].text == playerSide)
        //{
        //    GameOver();
        //}

        //if (buttonList[3].text == playerSide && buttonList[4].text == playerSide && buttonList[5].text == playerSide)
        //{
        //    GameOver();
        //}
        //if (buttonList[6].text == playerSide && buttonList[7].text == playerSide && buttonList[8].text == playerSide)
        //{
        //    GameOver();
        //}
        //if (buttonList[0].text == playerSide && buttonList[3].text == playerSide && buttonList[6].text == playerSide)
        //{
        //    GameOver();
        //}
        //if (buttonList[1].text == playerSide && buttonList[4].text == playerSide && buttonList[7].text == playerSide)
        //{
        //    GameOver();
        //}
        //if (buttonList[2].text == playerSide && buttonList[5].text == playerSide && buttonList[8].text == playerSide)
        //{
        //    GameOver();
        //}
        //if (buttonList[0].text == playerSide && buttonList[4].text == playerSide && buttonList[8].text == playerSide)
        //{
        //    GameOver();
        //}
        //if (buttonList[2].text == playerSide && buttonList[4].text == playerSide && buttonList[6].text == playerSide)
        //{
        //    GameOver();
        //}

        ChangeSides();
    }
    void GameOver() //This method is called when the game is over and locks all the buttons so no additional selections can be made.
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<Button>().interactable = false;
        }

    }

    void ChangeSides()  //This method is called after the player makes a selection, and assigns the opposite player. 
    {
        playerSide = (playerSide == "X") ? "O" : "X";
        playerColor = (playerColor == Color.red) ? Color.blue : Color.red;

        //TODO: figure out new code that functions as follows: playerColor = [switch color]
    }

}