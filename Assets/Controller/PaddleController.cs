using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;

    public KeyCode upKey;

    public KeyCode downKey;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //ubah posisi paddle jadi 0 agar tidak bergerak saat tidak ada input
        Vector2 movement = getInput();

        //move object
        moveObject (movement);
    }

    private Vector2 getInput()
    {
        //get input
        if (Input.GetKey(upKey))
        {
            //up
            Debug.Log("Paddle Speed : " + speed);
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            //down
            Debug.Log("Paddle Speed : " + speed);
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void moveObject(Vector2 movement)
    {
        // transform.Translate(movement * Time.deltaTime);
        rig.velocity = movement;
    }
}
