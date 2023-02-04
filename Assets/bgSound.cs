using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgSound : MonoBehaviour
{
    public AudioSource bg;
    // Start is called before the first frame update
    void Start()
    {
        bg.Play();
    }
}
