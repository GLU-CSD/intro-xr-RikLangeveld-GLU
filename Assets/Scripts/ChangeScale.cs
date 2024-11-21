using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
}
