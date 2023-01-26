using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] public AudioClip pop;
    [SerializeField] public AudioClip done;
    private AudioSource aSource;

    void Start()
    {
        aSource = GetComponent<AudioSource>();

        if (PlayerPrefs.GetInt("music", 1) == 1)
        {
            PlaySound(name);
        }
    }



    public void PlaySound(string name)
    {
        if (PlayerPrefs.GetInt("music", 1) == 0)
        {
            return;
        }
        else if (name == "pop")
        {
            aSource.PlayOneShot(pop);
        }
        else if(name == "done")
        {
            aSource.PlayOneShot(done);
        }

    }
}
