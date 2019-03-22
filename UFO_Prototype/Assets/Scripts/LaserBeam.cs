using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam : MonoBehaviour
{
    public bool insideRatio = false;

    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && insideRatio)
        {
            obj.transform.parent = gameObject.transform;
            obj.transform.Translate(new Vector3(0f, 0.3f, 0f));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Absorbable")
        {
            insideRatio = true;
            obj = other.gameObject.transform.parent.gameObject;
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Absorbable")
        {
            insideRatio = false;
            obj = null;
        }
            
    }
}
