using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SetVolume : MonoBehaviour
{
    [SerializeField] protected GameObject SetAudio;
    [SerializeField] protected AudioMixer myAudioMixer;
    
    [SerializeField] protected Slider audioSlide;
  
    

    protected void Start()
    {
        audioSlide.value = 0.4673916f;
        myAudioMixer.SetFloat("Volume", Mathf.Log10(audioSlide.value) * 40);
    }
    
    
    public void SetLevel()
    {
        myAudioMixer.SetFloat("Volume", Mathf.Log10(audioSlide.value) * 40);
    }
}
