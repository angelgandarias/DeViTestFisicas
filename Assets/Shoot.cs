using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Shoot : MonoBehaviour
{
    public int force;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            DoShoot();
        }
    }

    void DoShoot()
    {
       GameObject instanciatedBullet = Instantiate(bullet, this.transform.position, this.transform.rotation);
        //instanciatedBullet.transform.position = new Vector3 (0f, 0f, 0f);
        //instanciatedBullet.transform.rotation = Quaternion.Euler(0f, 0f, 90f);

        instanciatedBullet.GetComponent<Rigidbody>().AddForce(transform.forward*force);

    }
    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.blue);
        }
    }
}
