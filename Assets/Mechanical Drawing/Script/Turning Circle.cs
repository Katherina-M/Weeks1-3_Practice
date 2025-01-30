using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TurningCircle : MonoBehaviour
{
    public float speed = 0.06f;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, speed);
    }
}
