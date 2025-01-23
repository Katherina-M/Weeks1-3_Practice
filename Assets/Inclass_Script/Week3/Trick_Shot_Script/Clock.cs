using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Space key react
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space!");
        }

    }
}
