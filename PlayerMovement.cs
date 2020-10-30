using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;
using static System.Console;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float posX = 20;
    private float posY = 20;
    public float walkSpeed = 5;
    public GameObject ObjectPrefab;
    public Rigidbody2D pRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player "Horizontal" & "Vertical" input:
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Foward & Backward player movement:

        transform.Translate(UnityEngine.Vector3.up * verticalInput * Time.deltaTime * walkSpeed);
        if(transform.position.y < -posY)
        {
            transform.position = new UnityEngine.Vector3(transform.position.x, -posY, transform.position.z);
        }
        if(transform.position.y > posY)
        {
            transform.position = new UnityEngine.Vector3(transform.position.x, posY, transform.position.z);
        }

        //Left & Right player movement:

        transform.Translate(UnityEngine.Vector3.right * horizontalInput * Time.deltaTime * walkSpeed);
        if(transform.position.x < -posX)
        {
            transform.position = new UnityEngine.Vector3(-posX, transform.position.y, transform.position.z);
        }
        if(transform.position.x > posX)
        {
            transform.position = new UnityEngine.Vector3(posX, transform.position.y, transform.position.z);
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ObjectPrefab, ObjectPrefab.transform.position, ObjectPrefab.transform.rotation);
        }

    }
}
