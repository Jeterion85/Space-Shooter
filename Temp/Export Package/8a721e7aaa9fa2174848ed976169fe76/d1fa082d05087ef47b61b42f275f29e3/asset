using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotmodes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject Shotupgrade(GameObject shoot, float a, float b, float c, int level, float z)
    {
        GameObject laser = null;
        switch (level)
        {
         case 1:
            laser = Instantiate(shoot, new Vector3(a, b, c), Quaternion.Euler(0, 0, z));
            break;
         case 2:
             laser = Instantiate(shoot, new Vector3(a, b+0.5f, c), Quaternion.Euler(0, 0, z));
             laser = Instantiate(shoot, new Vector3(a, b-0.5f, c), Quaternion.Euler(0, 0, z));
             break;
         case 3:
             laser = Instantiate(shoot, new Vector3(a, b + 0.5f, c), Quaternion.Euler(0, 0,15+z));
             laser = Instantiate(shoot, new Vector3(a, b, c), Quaternion.Euler(0, 0, z));
             laser = Instantiate(shoot, new Vector3(a, b - 0.5f, c), Quaternion.Euler(0, 0,-15+z));
             break;
        }

        return laser;
    }
}
