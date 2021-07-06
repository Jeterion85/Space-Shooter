using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menumanagement : MonoBehaviour
{
    public GameObject buttonpanel;
    public GameObject optionspanel;
    public GameObject scorespanel;
    public GameObject optionsbutton;
    public GameObject scenepanel;

    public Text[] scoretext;
   // public Transform scorepanel;
   // public Text scoretext;

    public string[] score;

    // Start is called before the first frame update
    void Start()
    {
        buttonpanel.SetActive(true);
        optionspanel.SetActive(false);
        scorespanel.SetActive(false);
        scenepanel.SetActive(false);
        savemanagernew.checkfile();

        if (Application.platform == RuntimePlatform.Android)
        {
            optionsbutton.SetActive(false);
        }
        //scoretext = GameObject.FindGameObjectWithTag("ScoreText").GetComponentInChildren<Text>();
    }

    public void play()
    {
        scenepanel.SetActive(true);
        buttonpanel.SetActive(true);
    }

    // Update is called once per frame
    public void scores()
    {
        buttonpanel.SetActive(false);
        scorespanel.SetActive(true);
        score = savemanagernew.load();

        for (int i=0; i<score.Length -1; i++)
        {
            scoretext[i].text = score[i];
        }
        
        /*for (int i=0; i<score.Length -1; i++)
        {
            var st = Instantiate(scoretext, new Vector3(scorepanel.position.x, 800 -(100*i), scorepanel.position.z), Quaternion.identity);
            st.transform.SetParent(scorepanel); //= scorepanel.transform;
            //scoretext.GetComponentInChildren<Text>() = score[i];
        }*/
    }

    public void options()
    {
        buttonpanel.SetActive(false);
        optionspanel.SetActive(true);
    }

    public void Menu()
    {
        buttonpanel.SetActive(true);
        optionspanel.SetActive(false);
        scorespanel.SetActive(false);
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void Quitapplication()
    {
        Application.Quit();
    }

}
