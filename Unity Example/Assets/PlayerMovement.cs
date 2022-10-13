using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public PlayerMovement movement;

    public Rigidbody rb;

    public float forwardForce = 100f;
    public float sidewayForce = 30f;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, 40, forwardForce * Time.deltaTime);
        }
    }


}
