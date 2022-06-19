using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WidthUpController : MonoBehaviour
{
    public Collider2D ball;
    public Collider2D[] paddles;
    public PowerUpManager manager;
    private PaddleController PaddleController;

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
        if (collision == ball)
        {
            //increase paddle width
            Collider2D paddle = (PaddleController.paddlePosition == PaddleController.PaddlePosition.IS_RIGHT) ? paddles[1] : paddles[0];
            paddle.GetComponent<PaddleController>().activateWidthUp();
            manager.removePowerUp(gameObject);
        }
    }
}