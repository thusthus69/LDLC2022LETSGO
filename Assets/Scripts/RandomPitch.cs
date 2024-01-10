using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPitch : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        InvokeRepeating("PitchChanger", 0, 5f);
    }

    // Update is called once per frame
    void PitchChanger()
    {
        audioSource.pitch = Random.Range(0.1f, 3f);
    }
}
