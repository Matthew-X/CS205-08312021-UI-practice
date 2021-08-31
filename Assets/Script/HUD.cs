using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Transform StaminaBar;
    public Transform XPBar;
    public Transform HPBar;
    public UnityEngine.UI.Text staminaValue;
    public UnityEngine.UI.Text XPValue;
    public UnityEngine.UI.Text LVLValue;
    public AudioSource mrSandMan;
    public float staminaBase;

    float stamina;
    float XP;
    float HP;
    float LVL;
    bool canRun = true;

    public bool getRunning()
    {
        return canRun;
    }
    // Start is called before the first frame update
    void Start()
    {
        staminaValue.text = "" + staminaBase*2;
        mrSandMan.Play();
        mrSandMan.Pause();
    }

    // Update is called once per frame
    void Update()
    {

        //Increases and resets values ver level up
        if(XP >= staminaBase)
        {
            XP = 0;
            LVL++;
            HP = 0;
            staminaBase = staminaBase * 1.5f;
            LVLValue.text = "" + (int)(LVL);
        }


        //determines if stamina reached max value and if it can continue to decrease or increase
        if (stamina >= staminaBase*2)
        {
            canRun = false;
        }else if (stamina <= 0)
        {
            canRun = true;
        }


        //logic that determines if stamina, xp and hp values should be changing or not.
            if ((Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S)) && Time.timeScale > 0)
        {
            
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                if (canRun)
                {
                    stamina += Time.deltaTime * 30f;
                }
                else
                {
                    stamina -= Time.deltaTime * 5f;
                    HP += Time.deltaTime * 5f;
                }
                    mrSandMan.UnPause();
                    XP += 5 * Time.deltaTime;
                }
            else
            {
                if (canRun)
                {
                    stamina += Time.deltaTime * 10f;
                }
                else
                {
                    stamina -= Time.deltaTime * 10f;
                }
                mrSandMan.Pause();
                XP += 2 * Time.deltaTime;
            }
        }
        else if(stamina > 0)
        {
            mrSandMan.Pause();
            stamina -= 1f * Time.deltaTime*70;
            if (stamina > staminaBase * 2) stamina = staminaBase * 2;
        }

            //changing  text values and bars to it's values
        staminaValue.text = "" + (int)(staminaBase*2 - stamina);
        XPValue.text = "" + (int)(XP);
        StaminaBar.GetComponent<Image>().fillAmount = 1 - ((stamina/(staminaBase*2)));
        XPBar.GetComponent<Image>().fillAmount = ((XP/(staminaBase*2)));
        HPBar.GetComponent<Image>().fillAmount = 1 - ((HP/(staminaBase/2)));
    }
}
