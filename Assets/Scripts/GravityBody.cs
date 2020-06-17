using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class GravityBody : MonoBehaviour
{
    private PlanetGravity planet;
    private Rigidbody rb;
    private void Awake()
    {
        planet = GameObject.Find("Planet").GetComponent<PlanetGravity>();
        rb = this.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    private void Update()
    {
        planet.Attract(this.transform, rb);
    }
}
