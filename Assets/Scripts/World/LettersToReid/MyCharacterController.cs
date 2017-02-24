using UnityEngine;
using System.Collections;

public class MyCharacterController : MonoBehaviour {

    //script for controlling character movement

    public float moveSpeed = 10;
    public float oldY;
    public float climbSpeed = .1f;
    public bool isGrounded;
    public bool canClimb = false;
    

    

    // Use this for initialization
    void Start () {
        GetComponent<Renderer>().enabled = true;

	}

	// Update is called once per frame
	void Update () {
        //move left
        if (transform.position.y <= oldY + 0.1f && !isGrounded)
        {
            isGrounded = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().flipX = true;

            transform.Translate(-moveSpeed, 0, 0);

        }

        //move right
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().flipX = false;

            transform.Translate(moveSpeed, 0, 0);

        }
        // for climbing ladders
        if (canClimb)
        {
            if (Input.GetKey(KeyCode.W))
            {
                GetComponent<Rigidbody2D>().gravityScale = 0.0f;
                transform.Translate(0, climbSpeed, 0);

            }

            if (Input.GetKey(KeyCode.S))
            {
                GetComponent<Rigidbody2D>().gravityScale = 0.0f;
                transform.Translate(0, -climbSpeed, 0);
            }

        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 1f;
        }
    }

   
}
