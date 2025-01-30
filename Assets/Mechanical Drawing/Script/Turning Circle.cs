using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningCircle : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, 0.06f);
    }
}
