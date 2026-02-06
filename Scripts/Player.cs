using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.W))
            moveZ = 1f;
        if (Input.GetKey(KeyCode.S))
            moveZ = -1f;

        rb.linearVelocity = new Vector3(0f, rb.linearVelocity.y, moveZ * speed);

        if (Input.GetKey(KeyCode.R))
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

         if(Input.GetKey(KeyCode.Q))
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  
    }

    private void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
