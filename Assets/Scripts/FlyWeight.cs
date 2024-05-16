using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyWeight : Particles
{
    [SerializeField] Particles particles;
    [SerializeField] Transform coord;
    [SerializeField] Vector3 vector;
    [SerializeField] float speed;

    public void MovingParticles()
    {

    }
}
