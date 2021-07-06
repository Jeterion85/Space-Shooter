using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveControll : MonoBehaviour
{

    public GameObject movetarget;
    private Vector3 targetPos;
    public float cameraMoveSpeed;

    private static bool cameraExists;

  //  public BoxCollider2D bounds;
    private Vector3 boundsmin;
    private Vector3 boundsmax;

    private Camera thecamera;
    private float halfWidth;
    private float halfheight;
    // Start is called before the first frame update
    void Start()
    {
       // boundsmin = bounds.bounds.min;
       // boundsmax = bounds.bounds.max;

        thecamera = GetComponent<Camera>();
        halfheight = thecamera.orthographicSize;
        halfWidth = halfheight * Screen.width / Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = new Vector3(movetarget.transform.position.x, movetarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, cameraMoveSpeed * Time.deltaTime);
/*
        float clampx = Mathf.Clamp(transform.position.x, boundsmin.x + halfWidth, boundsmax.x - halfWidth);
        float clampy = Mathf.Clamp(transform.position.y, boundsmin.y + halfheight, boundsmax.y - halfheight);
        transform.position = new Vector3(clampx, clampy, transform.position.z);*/
    }

   /* public void setbounds(BoxCollider2D other)
    {
        bounds = other;
        boundsmin = bounds.bounds.min;
        boundsmax = bounds.bounds.max;
    }*/

    public IEnumerator shake()
    {
        
        transform.Rotate (0,0,-1);
        yield return new WaitForSeconds(0.125f);
        
        transform.Rotate(0, 0, 2);
        yield return new WaitForSeconds(0.125f);
       
        transform.Rotate(0, 0, -2);
        yield return new WaitForSeconds(0.125f);
        transform.Rotate(0, 0, 1);
        yield return new WaitForSeconds(0.125f);
        Debug.Log("3");

    }
}
