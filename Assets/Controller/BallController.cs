using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;

    private Rigidbody2D rig;

    public Vector3 resetPosition;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    private void Update()
    {
        //function to get component transform
        // Transform.position = transform.position + (new Vector3(0.1f, 0,0) * Time.deltaTime );
        // transform.Translate(speed * Time.deltaTime);
    }

    public void resetBall()
    {
        transform.position =
            new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
    }

    public void activateSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }
}
