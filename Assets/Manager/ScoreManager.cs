using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ScoreManager : MonoBehaviour
{
    //score for both player
    public int rightScore;

    public int leftScore;

    //max score
    public int maxScore;
    public BallController ball;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    //add right score
    public void addRightScore(int increment)
    {
        rightScore += increment;
        ball.resetBall();
        if (rightScore >= maxScore)
        {
            gameOver();
        }
    }

    //add left score
    public void addLeftScore(int increment)
    {
        leftScore += increment;
        ball.resetBall();
        if (leftScore >= maxScore)
        {
            gameOver();
        }
    }

    //game over method
    public void gameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
