using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CController : MonoBehaviour
{


    public float speed = 10.0f;
    private float translation;
    private float straffe;

    void Start()
    {
        // turn off cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            // turn on cursor
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        speed = 0f;
        Debug.Log("Text: ");
    }

}
