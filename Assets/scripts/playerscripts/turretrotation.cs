using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class turretrotation : MonoBehaviour
{
    public float tiltspeed;
    private float cooldown;

    public GameObject shoot;
    private shotmodes sm;
    private int shotlevel;

    float movex;
    float movey;
    bool firing;
    // Start is called before the first frame update
    void Start()
    {
        sm = FindObjectOfType<shotmodes>();
        cooldown = 0f;
        shotlevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, movex * -tiltspeed);

        if (cooldown > 0)
        {
            cooldown -= 1.5f * Time.deltaTime;
        }
        //shoot
        if (firing && cooldown <= 0)
        {           
            float z = gameObject.transform.localEulerAngles.z;
            GameObject shot = sm.Shotupgrade(shoot, transform.position.x, transform.position.y, transform.position.z, shotlevel, z);            
            cooldown = 2f;
            firing = false;
        }
        firing = false;
    }

    public void Turret(InputAction.CallbackContext context)
    {
        float direction = context.ReadValue<float>();
        movex = direction;        
    }

    public void Fire(InputAction.CallbackContext context)
    {
        firing = true;
    }
}
