using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDeleterTriggerExit : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name != "Plane")
        {
            Destroy(this.gameObject);
        }
    }
}