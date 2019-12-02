using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelaajaKoodi : MonoBehaviour
{
    public float nopeus;
    Vector3 suunta;
    Rigidbody RB;

    void Start()
    {
    RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate () {
    suunta.x = Input.GetAxis("Horizontal");
    suunta.z = Input.GetAxis("Vertical");
    RB.AddForce(suunta * nopeus);
    }
}
