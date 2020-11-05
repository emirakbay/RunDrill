using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody rb;

    public static PlayerMovement Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        MovePlayer();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (Input.GetMouseButton(0))
            {
                BoxParticle.Instance.SetParticlePosition(collision.gameObject);
                StartCoroutine(BoxParticle.Instance.Break());
                BoxParticle.Instance.DestroyBox(collision.gameObject);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (Input.GetMouseButton(0))
            {
                BoxParticle.Instance.SetParticlePosition(collision.gameObject);
                StartCoroutine(BoxParticle.Instance.Break());
                BoxParticle.Instance.DestroyBox(collision.gameObject);
            }
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game over");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (Input.GetMouseButton(0))
            {
                BoxParticle.Instance.SetParticlePosition(collision.gameObject);
                StartCoroutine(BoxParticle.Instance.Break());
                BoxParticle.Instance.DestroyBox(collision.gameObject);
            }
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game over");
        }
    }

    private void MovePlayer()
    {
        //Vector3 tempVect = new Vector3(0, 0, 1);
        //tempVect = tempVect.normalized * speed * Time.fixedDeltaTime;
        //rb.MovePosition(transform.position + tempVect);
        transform.position = transform.position + Vector3.forward * speed;
    }
}
