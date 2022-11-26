using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public int speed;
    public int jumpPower;
    public float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rigidbody.velocity = new Vector2(horizontal * speed, rigidbody.velocity.y);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpPower);
        }
    }
}
