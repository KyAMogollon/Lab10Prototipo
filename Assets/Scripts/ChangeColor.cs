using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Renderer _renderer;
    public MaterialPropertyBlock _propBlock;
    // Start is called before the first frame update
    void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _propBlock = new MaterialPropertyBlock();
    }
    private Color GetRandomColor()
    {
        Debug.Log("Cambiando de color");
        return new Color(
            r: Random.Range(0f, 1f),
            g: Random.Range(0f, 1f),
            b: Random.Range(0f, 1f)
            );
    }
    // Update is called once per frame
    void Update()
    {
        _renderer.GetPropertyBlock(_propBlock);
        _propBlock.SetColor("_Color", GetRandomColor());
        _renderer.SetPropertyBlock(_propBlock);
    }
}
