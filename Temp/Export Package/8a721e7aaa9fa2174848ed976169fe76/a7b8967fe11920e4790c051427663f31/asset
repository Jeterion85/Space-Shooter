using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class playmanager : MonoBehaviour
{
    public int score;
    public bool lose;
    public static bool paused;

    public GameObject losepanel;
    public GameObject pausepanel;
    public Text scoretext;    

    public PlayerInput playerInput;
    // Start is called before the first frame update
    void Start()
    {        
        losepanel.SetActive(false);
        pausepanel.SetActive(false);
        lose = false;
        paused = false;
        score = 0;
    }

    // Update is called once per frame
    public void playerlost()
    {
        scoretext.text = "Your score is:" + score;
        losepanel.SetActive(true);
        savemanagernew.add(score);
       // playerInput.SwitchCurrentActionMap("UI");
    }

    public void playagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("menuscene");
    }

    public void pause()
    {
        pausepanel.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void resume()
    {
        pausepanel.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }
}
