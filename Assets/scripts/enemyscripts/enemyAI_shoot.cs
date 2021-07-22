using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI_shoot : MonoBehaviour
{
    public float range;
    public GameObject bullet;

    private GameObject player;
    private bool found;
    private float cooldown;
    private CameraMoveControll cmc;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        cooldown = 0f;
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        cmc = FindObjectOfType<CameraMoveControll>();
        InvokeRepeating("FindTarget", 0f, 0.5f);
    }

    void FindTarget()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance <= range)
        {
            found = true;
        }
        else
        {
            found = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown > 0)
        {
            cooldown -= 1.5f * Time.deltaTime;
        }
        if (found)
        {
            Vector3 relativePos = player.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(Vector3.forward ,relativePos);
            transform.rotation = rotation;
        }
        if (cooldown <= 0 && found)
        {
            cooldown = 2f;
            shoot();
        }
       
    }

    void shoot()
    {
        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, transform.localEulerAngles.z+90));
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "shot")
        {
            //anim.SetBool("explosion", true);
            //pm.score = pm.score + 100;
            //if (random() == 2) { Instantiate(powerup, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity); }
            GetComponent<BoxCollider2D>().enabled = false;

            Destroy(collision.gameObject);
            StartCoroutine(cmc.shake());

            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            Destroy(gameObject);
        }
    }
}
