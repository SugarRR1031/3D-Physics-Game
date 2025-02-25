using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 0.5f;
    public int score = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.back * speed);
        }

        /* if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.left * speed);
        }*/

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
