using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    public bool isRight;
    public static PaddlePosition paddlePosition;
    public enum PaddlePosition
    {
        IS_RIGHT,
        IS_LEFT
    };
    public Collider2D ball;
    private Rigidbody2D rig;
    private Vector3 normalPaddle = new Vector3(0.6f, 2f, 1f);
    private Vector3 longPaddle = new Vector3(0.6f, 4f, 1f);
    private bool isPUActive = false;
    private bool isSpeedUpActive = false;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        gameObject.transform.localScale = normalPaddle;
    }

    // Update is called once per frame
    private void Update()
    {
        //ubah posisi paddle jadi 0 agar tidak bergerak saat tidak ada input
        Vector2 movement = getInput();

        //move object
        moveObject(movement);
    }

    private Vector2 getInput()
    {
        //get input
        if (Input.GetKey(upKey))
        {
            //up
            //Debug.Log("Paddle Speed : " + speed);
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            //down
            // Debug.Log("Paddle Speed : " + speed);
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            // set flag for last hit paddle
            paddlePosition = isRight ? PaddlePosition.IS_RIGHT : PaddlePosition.IS_LEFT;
            Debug.Log("last hit paddle : " + paddlePosition);
        }
    }

    private void moveObject(Vector2 movement)
    {
        // transform.Translate(movement * Time.deltaTime);
        rig.velocity = movement;
    }

    public void activateWidthUp()
    {
        if (isPUActive)
        {
            StopCoroutine("widthUpState");
        }
        StartCoroutine("widthUpState");
    }

    private IEnumerator widthUpState()
    {
        isPUActive = true;
        gameObject.transform.localScale = longPaddle;
        yield return new WaitForSeconds(5f);
        isPUActive = false;
        gameObject.transform.localScale = normalPaddle;
    }

    public void activateSpeedUp()
    {
        if (isSpeedUpActive)
        {
            StopCoroutine("speedUpState");
        }
        StartCoroutine("speedUpState");
    }

    private IEnumerator speedUpState()
    {
        isSpeedUpActive = true;
        speed *= 2;
        yield return new WaitForSeconds(5f);
        isSpeedUpActive = false;
        speed /= 2;
    }
}