using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetWhenFell : MonoBehaviour
{
    Vector3 startPos;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        System.Diagnostics.Debug.WriteLine(transform.position);
        if (transform.position.y - startPos.y < -10)
        {
            transform.position = startPos;
            rigidbody.velocity = Vector3.zero;
        }
    }
}
