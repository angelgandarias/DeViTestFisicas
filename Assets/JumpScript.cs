using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
        Rigidbody rBody ;
        [SerializeField]
        private int jumpForce;
        [SerializeField]
        private int speed;
        [SerializeField]
        private bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        rBody = this.gameObject.GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.forward*Time.deltaTime*speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.back * Time.deltaTime*speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }
}
