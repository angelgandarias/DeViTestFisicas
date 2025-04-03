using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public Rigidbody rBody;
    public bool randomize;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rBody = this.gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetKeyDown(KeyCode.Space)))
        {
            if (randomize)
            {
                int num = Random.Range(0, 4);
                switch (num)
                {
                    case 0:
                        rBody.AddForce(Vector3.up * force);
                        break;
                    case 1:
                        rBody.AddForce(Vector3.down * force);
                        break;
                    case 2:
                        rBody.AddForce(Vector3.left * force);
                        break;
                    case 3:
                        rBody.AddForce(Vector3.right * force);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                rBody.AddForce(Vector3.up * force);
            }
        }
    }
}
