using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ActiveParticleSystem : MonoBehaviour
{
    public GameObject PS;

    
    public void DisplayParticleSystem()
    {
        PS.SetActive(true);
    }
}
