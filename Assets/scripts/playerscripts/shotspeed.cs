//bullet script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotspeed : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 7.5f;       
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(speed, rb.velocity.y);
        rb.velocity = (transform.right) * speed;

        if (gameObject.transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }
}
