using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChefMove : MonoBehaviour
{
    Animator myAnim;
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Pause Menu");
        }

        myAnim.SetInteger("MoveState", 0);

        if (Input.GetKey(KeyCode.W))
        {
            myAnim.SetInteger("MoveState", 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            myAnim.SetInteger("MoveState", 2);
        }

        if (Input.GetKey(KeyCode.A))
        {
            myAnim.SetInteger("MoveState", 3);
        }

        if (Input.GetKey(KeyCode.D))
        {
            myAnim.SetInteger("MoveState", 4);
        }

        if ((Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.A)))
        {
            myAnim.SetInteger("MoveState", 5);
        }

        if ((Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.D)))
        {
            myAnim.SetInteger("MoveState", 6);
        }

        if ((Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.A)))
        {
            myAnim.SetInteger("MoveState", 7);
        }

        if ((Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.D)))
        {
            myAnim.SetInteger("MoveState", 8);
        }
    }
}
