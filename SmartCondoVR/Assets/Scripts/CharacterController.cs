using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
    public float speed = 10.0f;

    //turns off cursor so it will disappear from the screen during runtime
    //locks cursor to stay inside the Game window
	void Start ()
    {
        //Cursor.lockState = CursorLockMode.Locked;
	}

    //create controller's movement
    //ensure smooth movements by matching rate of update
    //return cursor
	void Update ()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        //if (Input.GetKeyDown("escape"))
            //Cursor.lockState = CursorLockMode.None;
	}
}
