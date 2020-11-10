using UnityEngine;

public class AnimatedRobotCollision : MonoBehaviour
{
    private Robot _robot;

    public bool isFinished;

    private void Start()
    {
        _robot = GetComponentInParent<Robot>();

        isFinished = false;
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
            _robot.ToggleDead();
        }

        if (collision.gameObject.CompareTag("FinishLine"))
        {
            isFinished = true;
            PlaneParticle.Instance.SetParticlePosition(gameObject.transform.position);
            StartCoroutine(PlaneParticle.Instance.PlayWinParticles());
            FindObjectOfType<GameManager>().NextLevel();
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
    }
}
