using UnityEngine;

public class AnimatedRobotCollision : MonoBehaviour
{
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
            var robotObj = gameObject.GetComponentInParent<Robot>();
            robotObj.ToggleDead();
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

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            var robotObj = gameObject.GetComponentInParent<Robot>();
            robotObj.ToggleDead();
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
            var robotObj = gameObject.GetComponentInParent<Robot>();
            robotObj.ToggleDead();
        }
    }

}
