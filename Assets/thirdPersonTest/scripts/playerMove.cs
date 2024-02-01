using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class playerMove : MonoBehaviour
{
    public playerSO playerStats;
    public Transform orientation;
    Rigidbody rb;
    Vector3 movement = Vector3.zero;
    //bool onGround = false;

    float forceMulti = 50;

    [SerializeField] GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        playerStats.bulletCount = 3;
        rb = gameObject.GetComponent<Rigidbody>();
        //rb.freezeRotation = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(movement * forceMulti, ForceMode.Force);
    }

    // Player movement
    private void OnMove(InputValue actionVal)
    {
        Debug.Log("move triggered");
        
        Vector2 val1 = actionVal.Get<Vector2>();

        movement = orientation.forward * val1.y + orientation.right * val1.x;
    }
}
