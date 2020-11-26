using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovemnt : MonoBehaviour
{
    [SerializeField] Vector2 _minPoint;
    [SerializeField] Vector2 _maxPoint;
    [SerializeField] float _speed;

    private void Start()
    {
        float width = Screen.width;
        float height = Screen.height;

        _minPoint = new Vector2(width * 0.1f, height * 0.1f);
        _maxPoint = new Vector2(width - width * 0.1f, height - height * 0.1f);
    }
    private void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        if (mousePos.x > _maxPoint.x) MoveRight(_speed * Time.deltaTime);
        else if (mousePos.x < _minPoint.x) MoveRight(-_speed * Time.deltaTime);

        if (mousePos.y > _maxPoint.y) MoveUp(_speed * Time.deltaTime);
        else if (mousePos.y < _minPoint.y) MoveUp(-_speed * Time.deltaTime);
    }
    private void MoveRight(float speed)
    {
        transform.Translate(Vector2.right * speed);
    }
    private void MoveUp(float speed)
    {
        transform.Translate(Vector2.up * speed);
    }
}
