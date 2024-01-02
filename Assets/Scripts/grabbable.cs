using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabbable : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 1f;
    public float defaultdrag;
    public float pickupdrag=5f;
    public LayerMask defaultlayer;
    private void Awake()
    {
        defaultlayer = gameObject.layer;
        rb = gameObject.GetComponent<Rigidbody>();
        defaultdrag = rb.mass;

    }


}
