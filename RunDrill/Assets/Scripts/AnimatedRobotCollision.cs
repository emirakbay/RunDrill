using UnityEngine;

public class AnimatedRobotCollision : MonoBehaviour
{
    private Robot _robot;

    private void Start()
    {
        _robot = GetComponentInParent<Robot>();
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
