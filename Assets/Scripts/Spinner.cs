using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float rotateSpeed = 1;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0);
    }
}
