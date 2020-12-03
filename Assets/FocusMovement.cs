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
        Vector2 newPos = camera.ScreenToWorldPoint(new Vector2(Screen.width / 2,Screen.height/2));
        transform.position = newPos;
    }
}
