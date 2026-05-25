//ScoreControl - this program handles the showcase of the score as the game progresses in Classic and Fruitbowl gamemodes
//Andrii Vdovyniuk - CompScie40s
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreControl : MonoBehaviour
{
    public static float scoreVal = 0;                         //the value of the scoreboard
    public TextMeshProUGUI scoreText;              //the text outputing the score
    // Start is called before the first frame update
    void Start()
    {
        //initialize the score to 0 at start of the program
       scoreVal = 0;
      scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //Update the score each frame with the new scoreVal
        scoreText.text = "Score: " + scoreVal;
    }
}
