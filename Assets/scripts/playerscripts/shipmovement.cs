using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shipmovement : MonoBehaviour
{
    public float speed;
    private int shotlevel;

    private Rigidbody2D rb;
    public GameObject shoot;

    private playmanager pm;
    private shotmodes sm;
    private float cooldown;    

    float movex;
    float movey;
    bool firing;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pm = FindObjectOfType<playmanager>();
        sm = FindObjectOfType<shotmodes>();
        
        cooldown = 0f;
        shotlevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, 0);       
       
        rb.velocity = new Vector2(movex * speed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, movey * speed);
        
    }

    public void Move(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();
        movex = direction.x;
        movey = direction.y;       
    }

    public void shooting(InputAction.CallbackContext context)
    {
        firing = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.gameObject.tag == "obstacle" && !pm.losepanel.activeInHierarchy)
        {            
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            pm.playerlost();
        }

        if(collision.gameObject.tag == "powerup")
        {
            if (shotlevel<3) { shotlevel += 1; }
            
            Destroy(collision.gameObject);
        }
    }

    
}
