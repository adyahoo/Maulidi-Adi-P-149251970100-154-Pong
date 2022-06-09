using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //get score text
    public Text rightScore;
    public Text leftScore;

    //get score from ScoreManager
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //update score
        rightScore.text = scoreManager.rightScore.ToString();
        leftScore.text = scoreManager.leftScore.ToString();
    }
}
