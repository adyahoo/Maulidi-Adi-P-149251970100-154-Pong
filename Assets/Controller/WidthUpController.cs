using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WidthUpController : MonoBehaviour
{
    public Collider2D ball;

    public Collider2D paddle;

    public PowerUpManager manager;

    private float timer = 0;

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
            paddle.GetComponent<PaddleController>().activateWidthUp();
            manager.removePowerUp (gameObject);
        }
    }
}
