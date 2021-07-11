using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelend : MonoBehaviour
{
    public int cutscene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D( Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(end());
        }
    }

    IEnumerator end()
    {
        PlayerPrefs.SetInt("cutscenetoload", cutscene);

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Cutscene-demo");
    }
}
