//GameOverScreen - this program will execute when the fruits reach the limit of the box or overflow out of the fruit bowl
//                                  it will then sned the user to the game over screen showing them the score that they got and letting them move to the next menu
//Andrii Vdovyniuk - CompsScie40s
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameOverScreen : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;                       //the text element that will updated with the score
    void Start()
    {
        //initialize the text element
        scoreText = GetComponent<TextMeshProUGUI>();
    }
    public void Setup()
    {
        float score;                                              //the score that the user got
        //Get the final score from the fruit object function
        score = FruitControl.FinalScore;
        //Out put the score to the text element; 
        scoreText.text = "Score: " + score;
    }

}
