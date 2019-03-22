using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    bool b = false;
    float t;
    public GameObject target;

    private void Update()
    {
        if (b)
        {
            t += Time.deltaTime / 12;
            transform.position = Vector3.Lerp(transform.position, target.transform.position, t);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LaserBeam")
            b = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Field")
        {
            gameObject.transform.parent = null;
            b = false;
        }
            
    }
}
