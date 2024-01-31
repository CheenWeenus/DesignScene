using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private void Start()
    {
        transform.position = cameraPosition.position;
    }
    private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
