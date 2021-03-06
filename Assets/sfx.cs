﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour {

    public static sfx instance = null;

    public AudioClip[] shortbeep;
    public AudioClip[] longbeep;
    public AudioClip[] meow;
    public AudioClip start;
    public AudioClip ende;
    private AudioSource source;

    private void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
    }

    private void Start()
    {
        playstart();
    }

    public void playshortbeep()
    {
        source.PlayOneShot(shortbeep[Random.Range(0, 4)]);
    }

    public void playlongbeep()
    {
        source.PlayOneShot(longbeep[Random.Range(0, 4)]);
    }

    public void playmeow()
    {
        source.PlayOneShot(meow[Random.Range(0, 4)]);
    }

    public void playstart()
    {
        source.PlayOneShot(start);
    }

    public void playende()
    {
        source.PlayOneShot(ende);
    }
}
