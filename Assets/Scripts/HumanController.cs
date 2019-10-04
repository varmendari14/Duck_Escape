using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterInputController))]
public class HumanController : MonoBehaviour
{
    private bool inAir;
    private Rigidbody rb;
    private float inputForward;
    private float forwardMaxSpeed = 1f;
    private float turnMaxSpeed = 1f;
    private float inputTurn = 1f;

    private CharacterInputController cinput;

    // Start is called before the first frame update
    void Start()
    {
        inAir = false;
        rb = GetComponent<Rigidbody>();
        cinput = GetComponent<CharacterInputController>();
        inputForward = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (cinput.enabled)
        {
            inputForward = cinput.Forward;
            inputTurn = cinput.Turn;
        }
        // Going backwards
        if(inputForward < 0f)
        inputTurn = -inputTurn;
        rb.MovePosition(rb.position +  this.transform.forward * inputForward * Time.deltaTime * forwardMaxSpeed);
        rb.MoveRotation(rb.rotation * Quaternion.AngleAxis(inputTurn * Time.deltaTime * turnMaxSpeed, Vector3.up));
    }

    //Physics
    void FixedUpdate() {
        // Rolling Mechanics
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        // Walking
        if (Input.GetKey(KeyCode.UpArrow)) {
            //rb.AddForce(movement * 100);
            //rb.AddForce(Vector3.left);
            GetComponent<Animator>().SetTrigger("Walk");
        }

        //Jumping
        if(!inAir & Input.GetKeyDown(KeyCode.Space)) {
            inAir = true;
            rb.AddForce(Vector3.up * 1000);
            GetComponent<Animator>().SetTrigger("Jump");
        }

        // Net Swing
        if (Input.GetKeyDown(KeyCode.N))
        {
            GetComponent<Animator>().SetTrigger("Swing");
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("goose")) {
            //Check for bite and apply damage
        }
    }

    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.CompareTag("ground") | collision.gameObject.CompareTag("jumpable")) {
            inAir = false;
        }
    }
}
