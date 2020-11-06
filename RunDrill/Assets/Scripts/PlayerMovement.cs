using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;

    public static PlayerMovement Instance;

    private Rigidbody rb;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
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

    public float getDistance()
    {
        return rb.transform.position.y;
    }
}
