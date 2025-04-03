using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
        Rigidbody rBody ;
        public int jumpForce;
        public int speed;
        public bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        rBody = this.gameObject.GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
