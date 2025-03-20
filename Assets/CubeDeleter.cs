using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDeleter : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Plane")
        {
            Destroy(collision.gameObject);
        }

    }
}
