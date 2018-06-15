using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{
    private void Update()
    {
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                // Get movement of the finger since last frame
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                transform.Rotate(Vector3.up, -touchDeltaPosition.x / 2);
            }
        }
    }
}

