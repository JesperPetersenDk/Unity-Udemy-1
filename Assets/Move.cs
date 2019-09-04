using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        InputKey();
    }

    private void InputKey()
    {
        //Disse to bruges til at fortælle om vi går Horizontal eller Vertical.
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        print(vertical + " " + horizontal);

        //Horizontal eller Vertical bruges til at fortælle vores vector3 om hvor vi gerne vil hen.
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * 60);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * 60);
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up);
        }


        gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);
    }
}
