using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public bool ship = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Field")
            gameObject.transform.parent = null;
    }
}
