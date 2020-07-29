using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewaysForce = 50f;
    public float forwardForce = 400f;
    public bool isStopped = false;
    void Start() 
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0);

        if (Input.GetKey("d"))
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);

        if (Input.GetKey("a"))
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
    }
    void isMoving()
    {
        if (rb.velocity.x >= 0f)
            isStopped = true;
    }
}
