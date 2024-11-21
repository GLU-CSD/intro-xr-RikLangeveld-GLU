using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SetColor(Color.green);
    }

    private void OnTriggerStay(Collider other)
    {
        float num = Random.Range(0f, 1f);
        float num1 = Random.Range(0f, 1f);
        float num2 = Random.Range(0f, 1f);

        SetColor(new Color(num, num1, num2));
    }

    private void OnTriggerExit(Collider other)
    {
        SetColor(Color.red);
    }

    private void SetColor(Color color)
    {
        Renderer renderer = GetComponent<Renderer>();
        Material mat = renderer.material;
        mat.color = color;
    }
}
