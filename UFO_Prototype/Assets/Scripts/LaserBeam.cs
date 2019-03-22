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
            obj.GetComponent<Rigidbody>().useGravity = false;
            obj.transform.parent = gameObject.transform;

            Vector3 v = obj.transform.position;

            

            obj.transform.Translate(new Vector3(0f, 3f * Time.deltaTime, 0f));
        }
        else if (obj != null)
        {
            obj.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Absorbable")
        {
            insideRatio = true;
            obj = other.gameObject.transform.parent.gameObject;
            
            Debug.Log(obj.name);
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
