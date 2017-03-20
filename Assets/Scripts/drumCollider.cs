using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drumCollider : MonoBehaviour
{
    private AudioSource mainSource;
    public AudioClip snare;
    public AudioClip hihat;
    public AudioClip tom1;
    public AudioClip tom2;
    public AudioClip tom3;
    public AudioClip crash;

    // Use this for initialization
    void Start()
    {
        mainSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider c)
    {
        Debug.Log("Hit something");

        mainSource = c.GetComponent<AudioSource>();

        switch (c.name)
        {
            case "Snare":
                mainSource.PlayOneShot(snare, 1);
                break;
            case "HiHat":
                mainSource.PlayOneShot(hihat, 1);
                break;
            case "Tom1":
                mainSource.PlayOneShot(tom1, 1);
                break;
            case "Tom2":
                mainSource.PlayOneShot(tom2, 1);
                break;
            case "Tom3":
                mainSource.PlayOneShot(tom3, 1);
                Debug.Log("Hit tom");
                break;
            case "Crash":
                mainSource.PlayOneShot(crash, 1);
                break;

        }
    }
}