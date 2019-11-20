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

    public bool hasDropped;
    public GameObject box;

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

            //Crouching/Sneaking
            if (Input.GetKey(KeyCode.LeftControl)) {
                anim.SetBool("Walking", false);
                anim.SetBool("Sneaking", true);
                controller.height = 1.25f;
                moveDir = new Vector3(0,0,1);
                moveDir *= sneakspeed;
                moveDir = transform.TransformDirection(moveDir);
            }

            //Running
            if (Input.GetKey(KeyCode.LeftShift)) {
                anim.SetBool("Walking", false);
                anim.SetBool("Running", true);
                moveDir = new Vector3(0,0,1);
                moveDir *= runSpeed;
                moveDir = transform.TransformDirection(moveDir);
            }

            // Box Drop
            if (Input.GetMouseButtonDown(1)) {
                anim.SetBool("Walking", false);
                anim.SetBool("Sneaking", false);
                anim.SetBool("Running", false);
                moveDir = new Vector3(0,0,0);
                GetComponent<Animator>().SetTrigger("DropBox");
                if (!hasDropped) {
                    hasDropped = true;
                    GameObject boxobj = Instantiate(box, transform.position + new Vector3(-0.5F, -0.5F, 0), Quaternion.identity) as GameObject;
                }
            }

            //Jumping
            if(Input.GetKeyDown(KeyCode.Space)) {
                moveDir.y = 3;
                GetComponent<Animator>().SetTrigger("Jump");
            }
        }

        // Stop moving
        if (Input.GetKeyUp(KeyCode.W)) {
            anim.SetBool("Walking", false);
            moveDir = new Vector3(0,0,0);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl)) {
            anim.SetBool("Sneaking", false);
            controller.height = 1.75f;
            moveDir = new Vector3(0,0,0);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift)) {
            anim.SetBool("Running", false);
            moveDir = new Vector3(0,0,0);
        }

        // Net Swing
        if (Input.GetMouseButtonDown(0)) {
                GetComponent<Animator>().SetTrigger("Swing");
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
