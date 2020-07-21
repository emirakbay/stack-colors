using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewaysForce = 500f;
    public float forwardForce = 2000f;
    public bool isStopped = false;
    void Start() 
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Debug.Log(rb.velocity);

        isMoving();

        // Add a forward force variable so that it can be manipulated over Unity Engine.
        rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);

        if (Input.GetKey("d"))
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);

        if (Input.GetKey("a"))
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
    }
    void isMoving()
    {
        if (rb.velocity.x >= 0f)
            Debug.Log("Object has stopped moving!!!!");
    }
}

