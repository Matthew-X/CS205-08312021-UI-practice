using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    
    
    
    public GameObject Panel;
    public GameObject VolumeSettingsMenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //stops time and calls pause menu and opposite
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Panel.gameObject.active)
            {
                Time.timeScale = 1;
                Panel.gameObject.SetActive(false);
                
            }
            else if (VolumeSettingsMenu.gameObject.active)
            {
                VolumeSettingsMenu.gameObject.SetActive(false);
                Panel.gameObject.SetActive(true);
            }
            else
            {
                Time.timeScale = 0;
                Panel.gameObject.SetActive(true);
            }
        }
    }

    //continues game
    public void ContinueScene()
    {
        Time.timeScale = 1;
        Panel.gameObject.SetActive(false);
    }
   
    //goes to volume settings
    public void VolimeSettingsOpen()
    {
        VolumeSettingsMenu.gameObject.SetActive(true);
        Panel.gameObject.SetActive(false);
    }
    

    //goes back to previous menu
    public void BackToMenu()
    {
        VolumeSettingsMenu.gameObject.SetActive(false);
        Panel.gameObject.SetActive(true);
    }

    //Changing Volume with volume mixer

    
}


