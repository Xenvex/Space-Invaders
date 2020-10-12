using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
    //Declare Public score variables here
{
    public TextMeshProUGUI scoring;
    public TextMeshProUGUI HIGHscoring;
    public int highScore = 0;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Leading Zero Stuff
        if(score < 10)
        {
            //1 Digit Score
            //Display Score
            scoring.text = "000" + score;
            
        }
        else if(score < 100 && score >= 10)
        {
            //2 Digit Score
            //Display Score
            scoring.text = "00" + score;
            
        }
        else if(score < 1000 && score >= 100)
        {
            //3 Digit Score
            //Display Score
            scoring.text = "0" + score;
            
        }
        

        //Updating HighScore
        if(score > highScore)
        {
            highScore = score;
            if (score < 10)
            {
                //1 Digit Score
                //Display HighScore
                HIGHscoring.text = "000" + highScore;
                
            }
            else if (score < 100 && score >= 10)
            {
                //2 Digit Score
                //Display HighScore
                HIGHscoring.text = "00" + highScore;
                
            }
            else if (score < 1000 && score >= 100)
            {
                //3 Digit Score
                //Display HighScore
                HIGHscoring.text = "0" + highScore;
               
            }
            //HIGHscoring.text = "" + highScore;
        }
        
    }
}
