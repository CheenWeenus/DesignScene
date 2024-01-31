using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class playInput2 : MonoBehaviour
{
    Vector2 movement = Vector2.zero;
    [SerializeField] float moveSpeed = 5;
    //rb is the rigidBody of object
    Rigidbody rb;
    [SerializeField] float bulletSpeed = 100;
    bool onGround = false;

    [SerializeField]
    GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        //must define the rigid body before can use
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += moveSpeed * Time.deltaTime * new Vector3(movement.x, 0, movement.y);
    }

    void OnMove(InputValue actionVal)
    {
        Vector2 val1 = actionVal.Get<Vector2>();

        movement.x = val1.x;
        movement.y = val1.y;


        rb.velocity = val1.y * transform.forward + val1.x * transform.right;
        rb.velocity *= moveSpeed;


        Debug.Log(val1);
    }

    void OnFire()
    {
        Debug.Log("Firing");

        GameObject bulletInstance = Instantiate(bullet, transform.position + 2.0f * transform.forward, Quaternion.identity);
        Rigidbody bulletRigidBody = bulletInstance.GetComponent<Rigidbody>();

        bulletRigidBody.AddForce(bulletSpeed * transform.forward);
    }

    void OnJump()
    {
        Debug.Log("Jumping");

        if(onGround)
        {
            rb.AddForce(new Vector3(0,1000,0));
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("ground"))
        {
            Debug.Log("OnGroundEnter");
            onGround = true;
            Debug.Log(onGround);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            Debug.Log("OnGroundExit");
            onGround = false;
        }
    }
}
