using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float walkSpeed, sprintMultiplier, rotationSpeed = 10f;
    float speed = 0;
    Rigidbody rb;
    float angle;

    // Use this for initialization
    void Start()
    {
        speed = walkSpeed;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        Vector3 v = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        if (Input.GetAxis("Sprint") > 0)
        {
            Debug.Log(Input.GetAxis("Sprint").ToString());
        }
        rb.velocity = v * speed * (1 + Input.GetAxis("Sprint") * sprintMultiplier);

        //Rotation
        angle = Mathf.Atan2(Input.GetAxis("RightHorizontal"), Input.GetAxis("RightVertical")) * Mathf.Rad2Deg+90;
        Debug.Log(angle);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, angle, 0), rotationSpeed * Time.deltaTime);
    }
}
