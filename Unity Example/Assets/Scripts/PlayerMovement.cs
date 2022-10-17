using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public PlayerMovement movement;

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewayForce = 300f;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, 40, forwardForce * Time.deltaTime);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }


}
