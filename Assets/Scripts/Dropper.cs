using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float dropTime = 3f;
    MeshRenderer meshRenderer;
    Rigidbody rb;


    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        meshRenderer.enabled = false;
        rb.useGravity = false; 
    }
    void Update()
    {
        
        DropCubes();
    }

    void DropCubes()
    {
        if(Time.time > dropTime)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
