using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float walkSpeed, sprintMultiplier;
    float speed = 0;
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        speed = walkSpeed;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Sprint"))
        //{
        //    speed = runSpeed;
        //}
        //else if (Input.GetKeyUp(KeyCode.LeftShift))
        //{
        //    speed = walkSpeed;
        //}
        Vector3 lookDirection = new Vector3(Input.GetAxis("RightHorizontal"), 0, Input.GetAxis("RightVertical"));
        Vector3 v = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (Input.GetAxis("Sprint")>0)
        {
            Debug.Log(Input.GetAxis("Sprint").ToString());
        }
        rb.velocity = v * speed *(1+Input.GetAxis("Sprint")*sprintMultiplier);
        transform.right = rb.velocity;
        //transform.LookAt(transform.position + lookDirection, Vector3.up);
    }
}
