using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class BirdMovement : MonoBehaviour
{
    // Start position of the bird
    Vector2 startPosition;

    // Total time the bird takes to complete the flight
    private float flightDuration;
    public AnimationCurve easeCurve;
    private float timeElapsed;
    private Vector2 offScreenPosition;

    void Start()
    {
        // Set the bird's starting position
        transform.position = startPosition;

        // Get the bird's current position in the scene
        Vector3 pos = transform.position;
        Vector3 screenPos = Camera.main.WorldToScreenPoint(pos);

        // Convert screen position back to world coordinates and move it off-screen
        pos = Camera.main.ScreenToWorldPoint(new Vector3(0, screenPos.y, screenPos.z));
        // Moving the bird far to the left
        offScreenPosition = new Vector3(pos.x * 2, (pos.y));

        // Store the initial position for interpolation
        startPosition = transform.position;
    }

    void Update()
    {
        // Set the duration for the bird's flight
        flightDuration = 10f;
        timeElapsed += Time.deltaTime;

        // Set the time between 0 to 1
        float normalizedTime = Mathf.Clamp01(timeElapsed / flightDuration);
        // Get the easing value from the animation curve
        float easeValue = easeCurve.Evaluate(normalizedTime);

        // Move the bird using Lerp, adjusting with the easeValue
        transform.position = Vector2.Lerp(startPosition, offScreenPosition, easeValue);

    }
}
