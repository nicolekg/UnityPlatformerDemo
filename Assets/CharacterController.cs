using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 2f;
    public float jumpHeight = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            if (Mathf.Abs(rb.velocity.y) < .1f)
            {
                jump();
            }
        }
        if (Input.GetKey("left"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
    void jump() 
    {
        print("jump");
        rb.AddForce(new Vector2(0, 1) * jumpHeight, ForceMode2D.Impulse);
    }
}
