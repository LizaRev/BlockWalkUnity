using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveX = 0f;

        if (Input.GetKey(KeyCode.A))
            moveX = -1f;

        if (Input.GetKey(KeyCode.D))
            moveX = 1f;

        rb.linearVelocity = new Vector3(moveX * speed, rb.linearVelocity.y, 0f);

       if(Input.GetKey(KeyCode.R))
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

       if(Input.GetKey(KeyCode.Q))
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
