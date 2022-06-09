using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;

    public bool isRight;

    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball){
            if(isRight){
                scoreManager.addRightScore(1);
            }else{
                scoreManager.addLeftScore(1);
            }
        }
    }
}
