using UnityEngine;

public class player : MonoBehaviour
{
    private float speed = 20f;
    private float speedRb = 2000f;

    private float turnSpeed = 45f;
    private float turnSpeedRb = 1500f;
    private float jumpSpeed = 5f;

    private float jumpForce = 100f;

    private Rigidbody playerRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }

    void FixedUpdate()
    {
        // horizontalInput = Input.GetAxis("Horizontal");
        // forwardInput = Input.GetAxis("Vertical");

        // playerRb.AddRelativeForce(Vector3.forward * speedRb * forwardInput);
        // playerRb.AddRelativeTorque(Vector3.up * turnSpeedRb * horizontalInput);
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * jumpForce,ForceMode.Impulse);

        }
    }

    void lateUpdate()
    {
        
    }
}
