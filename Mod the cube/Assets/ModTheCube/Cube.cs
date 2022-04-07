using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public Vector3 position = new Vector3(3, 4, 1);
    public Vector3 scale = Vector3.one * 2f;
    public Quaternion rotation = new Quaternion(10, 0, 0, 1);
    public Color color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    private Material material;

    void Start()
    {
        material = Renderer.material;
        transform.rotation = rotation;
    }
    
    void Update()
    {
        float colorOffsetR = Random.Range(-5f, 5f) * Time.deltaTime;
        float colorOffsetG = Random.Range(-5f, 5f) * Time.deltaTime;
        float colorOffsetB = Random.Range(-5f, 5f) * Time.deltaTime;
        color = new Color(color.r + colorOffsetR, color.g + colorOffsetG, color.b + colorOffsetB);

        transform.position = position;
        transform.localScale = scale;
        material.color = color;
        transform.Rotate(10.0f * Time.deltaTime, 20.0f * Time.deltaTime, 0.0f);
    }
}
