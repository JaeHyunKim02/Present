using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXManager : MonoBehaviour
{
    public AudioClip Touch;
    public AudioClip Clear;
    public AudioClip Drag;

    public AudioSource audio;
    //사용방법
    //부르고 싶은 부분에서
    //GameObject.Find("FXPlayer").GetComponent<FXManager>().SoundManager_F("이름");
    public void SoundManager_F(string audioName)
    {

        if (audioName == "Touch")
        {
            audio.PlayOneShot(Touch);
        }

        if (audioName == "Clear")
        {
            audio.PlayOneShot(Clear);
        }

        if (audioName == "Drag")
        {
            audio.PlayOneShot(Drag);
        }
    }
}
