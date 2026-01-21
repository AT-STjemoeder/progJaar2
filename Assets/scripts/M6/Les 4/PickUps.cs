using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PickUps : MonoBehaviour
{
    public delegate void Punten();

    public static Punten PlusPunten;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            PlusPunten?.Invoke();
            Destroy(gameObject);
        }
    }

}
