using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxParticle : MonoBehaviour
{
    private ParticleSystem particle;

    public static BoxParticle Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }


        particle = GetComponentInChildren<ParticleSystem>();
    }

    public void Play()
    {
        particle.Play();
    }

    private void Update()
    {
       
    }

    public void BlockParticle()
    {
        var particles = transform.GetChild(1);
        particles.SetParent(null);
        particles.gameObject.SetActive(true);
    }
}
