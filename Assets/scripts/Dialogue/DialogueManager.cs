using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dBox;
    public TMP_Text dText, speakertext;   
    public Image speakerimage;

    public Animator am;

    [HideInInspector] public bool dActive;
    [HideInInspector] public string[] dialogueLines;
    [HideInInspector] public int currentLine;    

    public Conversation convo;
    // Start is called before the first frame update
    void Start()
    {       
        dText.text = ""; //set text to blank (is blank by default though)       
    }

    // Update is called once per frame
    void Update()
    {
        if (dActive && Keyboard.current.spaceKey.wasPressedThisFrame) 
        {
            currentLine++;
            if (currentLine > convo.Getlength())
            {
                dBox.SetActive(false);
                dActive = false;
                currentLine = 0;
                Debug.Log("ok");
                StartCoroutine(end());
            }
            else
            {
                speakertext.text = convo.GetLineByIndex(currentLine).speaker.GetName(); //set speker name
                dText.text = convo.GetLineByIndex(currentLine).dialogue; //set dialogue
                dText.color = convo.GetLineByIndex(currentLine).color;
                speakerimage.sprite = convo.GetLineByIndex(currentLine).speaker.GetImage(); //set speaker image  
            }                  
        }
    }
   

    public void showDialogue()
    {
        dActive = true;
        dBox.SetActive(true);
        speakertext.text = convo.GetLineByIndex(currentLine).speaker.GetName(); //set speker name
        dText.text = convo.GetLineByIndex(currentLine).dialogue; //set dialogue
        speakerimage.sprite = convo.GetLineByIndex(currentLine).speaker.GetImage(); //set speaker image
    }

    IEnumerator end()
    {        
        am.SetTrigger("start");
        //ps.Play();

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(convo.Getname());
    }
}
