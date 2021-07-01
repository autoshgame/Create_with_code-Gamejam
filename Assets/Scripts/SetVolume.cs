using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SetVolume : MonoBehaviour
{
    [SerializeField] protected AudioMixer myAudioMixer;
    
    [SerializeField] protected Slider mySlide;
    

    public void Awake()
    {
        mySlide.value = 0.4673916f;
    }


    public void SetLevel()
    {
        myAudioMixer.SetFloat("MusicVol", Mathf.Log10(mySlide.value) * 20);
    }
}
