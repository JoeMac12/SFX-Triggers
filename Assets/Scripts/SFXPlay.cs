using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlay : MonoBehaviour
{
    public AudioSource SFXPlayer;

    private void OnTriggerEnter(Collider other)
    {
        SFXPlayer.Play();    
    }
}
