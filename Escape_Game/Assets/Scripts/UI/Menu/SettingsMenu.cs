using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Dropdown resolutionDropdown;

    Resolution[] resolutions;

    void Start ()
    {
       resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutiIndex = 0;

        for(int i =0; i<resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutiIndex = i;
            }
        }


        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value=currentResolutiIndex;
        resolutionDropdown.RefreshShownValue();

    } 

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetResolut (int resolIndex)
    {
        Resolution resolution = resolutions[resolIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetFullscreen (bool fulscren)
    {
        Screen.fullScreen = fulscren;

    }
}
