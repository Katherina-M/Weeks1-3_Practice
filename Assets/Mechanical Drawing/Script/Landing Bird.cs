using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingBird : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 endPos;

    public AnimationCurve flyCurve;
    private float t;
    private int flying; // 0 = not flying, 1 = flying

    void Start()
    {
        t = 0;
        startPos = transform.localPosition; // Initial position
        flying = 0; // Bird not flying
    }

    void Update()
    {
        // If mouse is clicked, start flying
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            flying = 1; // Activate movement
        }

        // If flying, update position
        if (flying == 1)
        {
            // Adjust speed by changing the multiplier
            t += Time.deltaTime * 0.3f; 

            // Move the bird from startPos to endPos
            endPos = transform.localPosition - startPos;
            transform.localPosition = Vector3.Lerp(startPos, endPos, flyCurve.Evaluate(t));

            // Scale the bird using the curve
            transform.localScale = Vector2.one * flyCurve.Evaluate(t);

        }
    }
}