using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    public float thrust = 10f;
    public float rotationSpeed = 5f;
    public float backwardForce = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * thrust, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.down * thrust, ForceMode.Impulse);
        }

        float angle = Mathf.Clamp(rb.velocity.y * rotationSpeed, -90, 90);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            
            rb.AddForce(Vector3.left * backwardForce, ForceMode.Impulse);
        }
        else if (collision.gameObject.CompareTag("Muerte"))
        {

            SceneManager.LoadScene("Derrota");
        }
    }
}

