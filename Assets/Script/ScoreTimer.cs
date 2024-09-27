using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTimer : MonoBehaviour
{
    public int score;
    public Text scoretxt;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        InvokeRepeating("UpdateScore", 0.0f, 0.1f);
    }

    void UpdateScore()
    {
        score += 1;
        string stext = score.ToString();
        while(stext.Length < 4)
        {
            stext = "0" + stext;
        }
        scoretxt.text = stext;
    }
}
