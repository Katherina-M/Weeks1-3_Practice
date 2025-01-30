using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBird: MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 endPos;
    
    public AnimationCurve flyCurve;
    [Range(0, 1)]
    public float t;

    void Start()
    {
        t = 0;
        startPos = transform.localPosition;
        
    }

    
    void Update()
    {
        
        t += Time.deltaTime * 0.05f;

        // Lerp bird movement with the curve
        endPos = transform.localPosition - startPos;

        transform.localPosition = Vector3.Lerp(startPos, endPos, flyCurve.Evaluate(t));

        // Scale the bird dynamically
        transform.localScale = Vector2.one * flyCurve.Evaluate(t);
    }
}
