using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip_tracing;
    bool produce_tracing_sound;
    public AudioClip clip_complete;
    bool produce_on_complete_sound;

    void Update()
    {
        produce_tracing_sound = gameObject.GetComponent<Tracing>().Tracing_begin;
        produce_on_complete_sound = gameObject.GetComponent<Tracing>().tracing_complete;

        if (produce_tracing_sound)
        {
            source.PlayOneShot(clip_tracing);
        }
        else if (produce_on_complete_sound) {
            source.PlayOneShot(clip_complete);
        }
    }
}
