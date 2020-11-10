using System.Collections;
using UnityEngine;

public class PlaneParticle : MonoBehaviour
{
    public ParticleSystem particle;

    public static PlaneParticle Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        particle = GetComponentInChildren<ParticleSystem>();

    }

    public IEnumerator PlayWinParticles()
    {
        particle.Play();

        yield return new WaitForSeconds(particle.main.startLifetime.constantMax);
    }

    public void SetParticlePosition(Vector3 pos)
    {
        particle.transform.position = pos;
    }
}