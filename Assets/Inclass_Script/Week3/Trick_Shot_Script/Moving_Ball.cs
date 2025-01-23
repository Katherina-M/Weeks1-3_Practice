using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Ball : MonoBehaviour
{
    float shapeSpeed = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the ball between the framw
        Vector3 pos = transform.position;
        pos.x += shapeSpeed;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            shapeSpeed = shapeSpeed * -1;
        }

        transform.position = pos;

        
    }
}
