using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
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


        gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);
    }
}
