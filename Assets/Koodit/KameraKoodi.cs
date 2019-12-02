using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKoodi : MonoBehaviour
{
    public Transform pelaaja;

    void Start()
    {

    }


    void Update()
    {
        transform.LookAt(pelaaja);
    }
}