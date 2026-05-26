//Menu_buttons - this program will handle all the functionality of the on screen buttons relating to navigating the menus of the game
//                              all buttosn can call one function upon button press, this program will store all those functions
//Andrii Vdovyniuk - CompScie 40s 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Hello if oyu are reading this something worked help fix my code this was in highschool dont judge too hard!!!
public class Menu_buttons : MonoBehaviour
{
    //StartGame - "Start" button functionality, sends the user to level select screen
    /*no parameters*/
    public void LevelOptions()
    {
        SceneManager.LoadScene("Level options");
    }

    //ToMaintMenu - Returns the user to the main screen
    /*no parameters*/
    public void ToMainMenu()
    {
        SceneManager.LoadScene("Title Screen");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    //StartTutorial - sends the user to the game tutorial screen
    //no parameters
    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial Screen");
    }

    //ClassicGamePlay - sends the user to the main game mode of the game
    //no parameters
    public void ClassicGamePlay()
    {
        //reload all values (static variables dont get reset automatically when a scene loads so we have to do it by hand)
        BasketControl.spawnYet = false;
        BasketControl.NewFruit = false;
        BasketControl.FruitVal = 0;
        BasketControl.collTotal = 0;
        SceneManager.LoadScene("Classic GameMode");
    }

    //Fruit Bowl GamePlay - sends the user to the alternate "fruitbowl" game mode of the game
    //no parameters
    public void FruitBowlGamePlay()
    {
        //reload all values (static variables dont get reset automatically when a scene loads so we have to do it by hand)
        BasketControl.spawnYet = false;
        BasketControl.NewFruit = false;
        BasketControl.FruitVal = 0;
        BasketControl.collTotal = 0;
        SceneManager.LoadScene("Fruit Bowl Gamemode");
    }
}

