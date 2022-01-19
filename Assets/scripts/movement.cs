using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Vector2 speed = new Vector2(3, 3);
    public Vector2 jumpHeight = new Vector2 (3, 3);
    bool isGrounded;
    public LayerMask mask;
    public float maxDistance;

    private void Start()
    {
        isGrounded = true;
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputX, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);

        isGrounded = Physics2D.Raycast(transform.position, -transform.up, maxDistance, mask);
        Debug.DrawRay(transform.position, -transform.up * maxDistance);

        if (isGrounded)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);

                isGrounded = false;
            }
        }
    }
}
