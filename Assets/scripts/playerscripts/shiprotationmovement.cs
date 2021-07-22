//NOT IN USE
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shiprotationmovement : MonoBehaviour
{
    public float speed;
    public float tiltspeed;
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
        rb.velocity = new Vector2((transform.right.x) * movey * speed, (transform.right.y) * movey * speed);
        transform.Rotate(0, 0, movex * -tiltspeed);
        /* if (Input.GetAxis("Vertical") >0)
         {
             rb.velocity = new Vector2((transform.right.x) * speed, (transform.right.y) * speed) ;
         }

         if (Mathf.Abs(Input.GetAxis("Horizontal"))> 0)
         {
             transform.Rotate(0, 0, Input.GetAxis("Horizontal")* -tiltspeed);
         }*/

        if (cooldown > 0)
        {
            cooldown -= 1.5f * Time.deltaTime;
        }
        //shoot
        if (firing && cooldown <= 0)
        {
            // var shot = Instantiate(shoot, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, gameObject.transform.localEulerAngles.z));
            float z = gameObject.transform.localEulerAngles.z;
            GameObject shot = sm.Shotupgrade(shoot, transform.position.x, transform.position.y, transform.position.z, shotlevel,z);
            //shot.transform.parent = gameObject.transform;
            cooldown = 2f;
            firing = false;
        }
        firing = false;
    }

    public void Move(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();
        movex = direction.x;
        movey = direction.y;
        Debug.Log(direction);
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

        if (collision.gameObject.tag == "powerup")
        {
            if (shotlevel < 3) { shotlevel += 1; }

            Destroy(collision.gameObject);
        }
    }
}
