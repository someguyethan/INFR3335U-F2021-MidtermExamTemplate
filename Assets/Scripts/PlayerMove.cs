using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public Transform cam;
    public Animator anim;
    public float speed = 4f;

    Vector3 movement = Vector3.zero;
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void FixedUpdate()
    {
        //Move();
    }

    void Update()
    {
        MyInput();

        if (movement.x != 0f || movement.z != 0f)
            anim.SetTrigger("isMoving");
        else if (movement.x == 0f && movement.z == 0f)
            anim.SetTrigger("isIdle");
    }

    void MyInput()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");

        movement = rb.transform.forward * yInput + rb.transform.right * xInput;

        cam.LookAt(player);
        player.rotation = Quaternion.Euler(new Vector3(0, cam.rotation.eulerAngles.y, 0));
    }

    void Move()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(movement * speed * Time.deltaTime, ForceMode.Force);
    }
}
