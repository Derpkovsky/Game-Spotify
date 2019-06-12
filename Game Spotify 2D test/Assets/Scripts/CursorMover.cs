using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMover : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed;

    void Update()
    {
        //if (Input.GetMouseButton(1))
        //{
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        //}
    }
}
