using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstaclefunctions : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed;
    public GameObject powerup;

    private playmanager pm;
    private CameraMoveControll cmc;
    private stationhealth sh;
    private spawnprefab sp;

    private Animator anim;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        pm = FindObjectOfType<playmanager>();
        cmc = FindObjectOfType<CameraMoveControll>();
        sh = FindObjectOfType<stationhealth>();
        sp = FindObjectOfType<spawnprefab>();

        speed = sp.speed;        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (-transform.right) * speed;
        speed = speed + 0.001f;

        if(gameObject.transform.position.x < -20 || gameObject.transform.position.x > 20)
        {
            if (SceneManager.GetActiveScene().name == "station") { sh.damage(); }
            
            Destroy(gameObject);            
        }
    }

    int random()
    {
        int X = Random.Range(0,10);
        return X;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "shot")
        {
            anim.SetBool("explosion", true);
            pm.score = pm.score + 100;
            if (random() == 2) { Instantiate(powerup, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity); }
            GetComponent<BoxCollider2D>().enabled = false;

            Destroy(collision.gameObject);
            StartCoroutine(cmc.shake());

            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        }
    }

    void boom()
    {              
       Destroy(gameObject);
    }
}
