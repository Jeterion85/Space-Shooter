using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI_movement : MonoBehaviour
{
    private Vector3 startingpos;
    private Vector3 roampos;    
    private Rigidbody2D rb;

    public float speed; // Number of frames to completely interpolate between the 2 positions
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingpos = transform.position;
        roampos = roaming();
        InvokeRepeating("move", 0f, 2f);
    }
    
    private void move()
    {
        rb.velocity = new Vector2(0, 0);

        rb.velocity = new Vector2(Getdirection().x * speed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, Getdirection().y * speed);        
    }

    Vector2 roaming()
    {
        return startingpos + Getdirection() * Random.Range(2f, 10f);
    }

    Vector3 Getdirection()
    {
        return new Vector3(Random.Range(-1, 2), Random.Range(-1, 2));
    }       

}
