using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDeleter : MonoBehaviour
{
    int health = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Plane")
        {
            Debug.Log("Target hit");
            health -= 1;
            if (health <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("Target destroyed");
            }
        }
    }
}
