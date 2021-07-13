using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelend : MonoBehaviour
{
    public int cutscene;
    public Animator am;

    private ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = gameObject.GetComponent<ParticleSystem>();
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
        am.SetTrigger("start");
        ps.Play();

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Cutscene-demo");
    }
}
