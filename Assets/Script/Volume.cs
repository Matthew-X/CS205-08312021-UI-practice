using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{

    public AudioMixer mixer;
    public Toggle MuteToggle;
    public Slider slider;

    //set's volume to it's volumeslider value.
    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10 (sliderValue) * 20);
    }

    //set's volume to 0 and disables volume slider.
    public void MuteToggleActive(float sliderValue)
    {
        slider.gameObject.SetActive(!MuteToggle.isOn);

        if (!MuteToggle.isOn)
        {
            mixer.SetFloat("MusicVol", Mathf.Log10(slider.value) * 20);
        }
        else
        {
            mixer.SetFloat("MusicVol", Mathf.Log10(0.001f) * 20);
        }
    }
}
