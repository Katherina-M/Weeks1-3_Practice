using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bouncing : MonoBehaviour
{
    Vector2 Ball;
    float speed = 0.1f;
    public AnimationCurve curve;
   
    [Range(0,1)]
    public float t;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;

        if (pos.x < 0 || pos.x > 10)
        {
            speed = speed * -1;
        }
        transform.position = pos;

        t += Time.deltaTime;
        if(t > 1)
        {
            t = 0;
        }
        transform.localScale = Vector2.one * curve.Evaluate(t);
    }
}
