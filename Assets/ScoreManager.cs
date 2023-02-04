using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text textScore;
    public int score;
    public int yPosition;
    public string largeSign;

    void Start()
    {
        score = 0;
        yPosition = 0;
        textScore.text = score.ToString() + " points";
    }

    void Update()
    {
        yPosition = (int)GameObject.FindGameObjectWithTag("Player").transform.position[1];
        if (score < yPosition)
        {
            score = yPosition;
            if (1000000 < score)
            {
                largeSign = "M";
            }
            else if (1000 < score)
            {
                largeSign = "K";
            }
            else
            {
                largeSign = "";
            }
        }
        textScore.text = score.ToString() + largeSign + " points";
    }
}
