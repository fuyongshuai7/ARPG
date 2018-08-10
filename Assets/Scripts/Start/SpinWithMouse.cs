using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpinWithMouse : MonoBehaviour
{
    private float speed = 10;

    private void OnMouseDrag()
    {
        transform.Rotate(Vector3.up, -Input.GetAxis("Mouse X") * speed);
    }
}
