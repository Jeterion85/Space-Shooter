using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene_manager : MonoBehaviour
{
    public int a;

    public GameObject[] cutscenes;
    // Start is called before the first frame update

    void Awake()
    {
        a = PlayerPrefs.GetInt("cutscenetoload");
    }

    void Start()
    {
        for (int i=0; i<cutscenes.Length; i++)
        {
            cutscenes[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (a == 1)
        {
            cutscenes[0].SetActive(true);
        }
        if (a ==2)
        {
            cutscenes[1].SetActive(true);
        }
    }
}
