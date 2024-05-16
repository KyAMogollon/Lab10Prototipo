using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    [SerializeField] Color color;
    [SerializeField] Sprite sprite;
    [SerializeField] protected int numeroDeParticulas;

    public Particles()
    {

    }
    public void SetColor(Color colors)
    {
        color = colors;
    }
    public void SetSprite(Sprite sprites)
    {
        sprite = sprites;
    }
}
