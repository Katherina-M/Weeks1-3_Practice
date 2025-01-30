using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float floatingSpeed = 0.01f;

    void Start()
    {
        
    }

    void Update()
    {
        // Get the current position of the object
        Vector3 pos = transform.position;
        // Move the object to the right with set floating speed
        pos.x += floatingSpeed;

        // Get screen size
        Vector3 screenPos = Camera.main.WorldToScreenPoint(pos);

        // If the ball exits the right side, teleport it to the left
        if (screenPos.x > Screen.width)
        {
            pos = Camera.main.ScreenToWorldPoint(new Vector3(0, screenPos.y, screenPos.z));
        }
        // If the ball exits the left side, teleport it to the right
        else if (screenPos.x < 0)
        {
            pos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, screenPos.y, screenPos.z));
        }

        // Apply the updated position to the object
        transform.position = pos;
        transform.Translate(floatingSpeed, 0, 0);
    }
}
