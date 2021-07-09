using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DialogueHolder : MonoBehaviour
{   
    private DialogueManager dMan;      
    public Conversation convoholder;

    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();       
    }

    // Update is called once per frame
    void Update()
    {
       if (!dMan.dActive)
       {              
          dMan.convo = convoholder;
          dMan.currentLine = 0;
          dMan.showDialogue();               
       }        
    }

     
    
}
