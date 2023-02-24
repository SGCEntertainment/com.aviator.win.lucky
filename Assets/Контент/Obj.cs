using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    private void Start()
    {
        Destroy(gameObject, 8);
    }
}
