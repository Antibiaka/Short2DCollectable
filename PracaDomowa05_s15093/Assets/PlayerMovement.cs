using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 400;
   
    private bool isGrounded;

    [HideInInspector]
    public static Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        BaseMovement();
    }
    void BaseMovement() {

        float xDisplacement = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);
        if (xDisplacement > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (xDisplacement < 0) {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) //jump and test @on ground@
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
            isGrounded = false;
        }

        if (Input.GetKey(KeyCode.LeftShift) && isGrounded) {
            xDisplacement = Input.GetAxis("Horizontal") * speed * 2;  //SHIFT  mode activated , speeds up player 
            rb.velocity = new Vector2(xDisplacement, rb.velocity.y);
        }
    }
    void OnCollisionEnter2D(Collision2D col) {

        if (col.transform.tag == "Ground") {
            isGrounded = true;
        }

    }
    void OnCollisionExit2D(Collision2D col) {

        if (col.transform.tag == "Ground") {
            isGrounded = false;
        }

    }


}
