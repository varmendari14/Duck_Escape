using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBasicControl : MonoBehaviour
{
    float sneakspeed = 1;
    float speed = 2;
    float runSpeed = 4;
    float rotSpeed = 80;
    float rot = 0f;
    float gravity = 8;

    Vector3 moveDir = Vector3.zero;

    CharacterController controller;
    Animator anim;
    private Rigidbody rb;

    void Start() {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        // Debug.Log(controller.isGrounded ? "GROUNDED" : "NOT GROUNDED");
        if (controller.isGrounded) {
            // Walking and
            // Used to be just GetKey
            if (Input.GetKey(KeyCode.W)) {
                anim.SetBool("Walking", true);
                moveDir = new Vector3(0,0,1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
            }
            if (Input.GetKeyUp(KeyCode.W)) {
                anim.SetBool("Walking", false);
                moveDir = new Vector3(0,0,0);
            }

            //Crouching/Sneaking
            if (Input.GetKey(KeyCode.C)) {
                anim.SetBool("Walking", false);
                anim.SetBool("Sneaking", true);
                moveDir = new Vector3(0,0,1);
                moveDir *= sneakspeed;
                moveDir = transform.TransformDirection(moveDir);
            }
            if (Input.GetKeyUp(KeyCode.C)) {
                anim.SetBool("Sneaking", false);
                moveDir = new Vector3(0,0,0);
            }

            //Running
            if (Input.GetKey(KeyCode.R)) {
                anim.SetBool("Walking", false);
                anim.SetBool("Running", true);
                moveDir = new Vector3(0,0,1);
                moveDir *= runSpeed;
                moveDir = transform.TransformDirection(moveDir);
            }
            if (Input.GetKeyUp(KeyCode.R)) {
                anim.SetBool("Running", false);
                moveDir = new Vector3(0,0,0);
            }
        }

        // Net Swing
        if (Input.GetKeyDown(KeyCode.N)) {
                GetComponent<Animator>().SetTrigger("Swing");
        }
        //Jumping
        if(Input.GetKeyDown(KeyCode.Space)) {
            moveDir.y = 5;
            GetComponent<Animator>().SetTrigger("Jump");
        }

        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }

    //Physics
    // void FixedUpdate() {
    //     // Rolling Mechanics
    //     float moveHorizontal = Input.GetAxis("Horizontal");
    //     float moveVertical = Input.GetAxis("Vertical");

    //     rot += moveHorizontal * rotSpeed * Time.deltaTime;
    //     transform.eulerAngles = new Vector3(0, rot, 0);

    //     moveDir.y -= gravity * Time.deltaTime;
    //     controller.Move(moveDir * Time.deltaTime);

    //     Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

    //     rb.AddForce(movement * 1000);

    // }

    // public AudioClip catchAudio;
    // void onCollisionEnter (Collider other) {
    //     if (other.gameObject.CompareTag("pickup")) {
    //         other.gameObject.SetActive(false);
    //         AudioSource.PlayClipAtPoint(catchAudio, transform.position);
    //     }
    // }
}
