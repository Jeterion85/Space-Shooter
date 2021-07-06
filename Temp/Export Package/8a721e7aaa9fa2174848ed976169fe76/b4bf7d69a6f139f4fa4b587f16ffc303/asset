using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsmanager : MonoBehaviour
{
    Resolution[] resolutions;
    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;
        resolutions[0].width = 800;
        resolutions[1].width = 1280;
        resolutions[2].width = 1920;
        resolutions[0].height = 600;
        resolutions[1].height = 720;
        resolutions[2].height = 1080;

    }

    // Update is called once per frame
    public void fullscreen(bool Full)
    {
        Screen.fullScreen = Full;
    }

    public void screenresolution(int index)
    {
        Resolution res = resolutions[index];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }
}
