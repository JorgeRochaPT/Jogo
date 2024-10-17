using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXTRA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "coin")
        {
            other.gameObject.transform.position = new Vector3(-300000000, -300000000);
            //Destroy(other.gameObject);
        }
    }



}
