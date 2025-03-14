using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position += Vector3.left * Time.deltaTime*3;

        }
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position += Vector3.forward * Time.deltaTime*3;

        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.position += Vector3.back * Time.deltaTime * 3;

        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += Vector3.right * Time.deltaTime*3;

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.name != "Plane")
        {
            Destroy(collision.gameObject);
        }
        
    }
}
