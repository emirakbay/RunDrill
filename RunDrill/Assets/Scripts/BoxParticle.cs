using System.Collections;
using UnityEngine;

public class BoxParticle : MonoBehaviour
{
    public ParticleSystem particle;

    public static BoxParticle Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        particle = GetComponentInChildren<ParticleSystem>();
    }

    public IEnumerator Break()
    {
        particle.Play();

        yield return new WaitForSeconds(particle.main.startLifetime.constantMax);
    }

    public void DestroyBox(GameObject objToDestroy)
    {
        Destroy(objToDestroy);
    }

    public void SetParticlePosition(GameObject objToSet)
    {
        particle.transform.position = objToSet.gameObject.transform.position;
    }

}
