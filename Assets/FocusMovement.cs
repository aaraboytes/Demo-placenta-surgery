using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusMovement : MonoBehaviour
{
    private Camera camera;
    private void Start()
    {
        camera = Camera.main;
    }
    private void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 newPos = camera.ScreenToWorldPoint(mousePos);
        transform.position = newPos;
    }
}
