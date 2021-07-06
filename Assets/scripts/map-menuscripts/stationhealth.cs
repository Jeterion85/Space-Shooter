using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stationhealth : MonoBehaviour
{
    public Slider sliderbar;
    public int health;
    private playmanager pm;
    // Start is called before the first frame update
    void Start()
    {
        pm = FindObjectOfType<playmanager>();
        sliderbar.maxValue = health;
        sliderbar.value = sliderbar.maxValue;
    }

    // Update is called once per frame
    public void damage()
    {
        sliderbar.value -= 1;
        if (sliderbar.value == 0 && !pm.losepanel.activeInHierarchy)
        {
            pm.playerlost();
        }
    }
}
