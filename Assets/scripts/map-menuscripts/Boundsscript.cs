using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundsscript : MonoBehaviour
{
    private BoxCollider2D bounds;
    private CameraMoveControll thecamera;
    // Start is called before the first frame update
    void Start()
    {
        bounds = GetComponent<BoxCollider2D>();
        thecamera = FindObjectOfType<CameraMoveControll>();
       // thecamera.setbounds(bounds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
