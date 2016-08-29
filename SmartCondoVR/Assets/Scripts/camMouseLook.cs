using UnityEngine;
using System.Collections;

public class camMouseLook : MonoBehaviour
{
    Vector2 mouseLook; //keeps track of total movement camera has made and added to controller
    Vector2 smoothV; 
    public float sensitivity = 5.0f; //mouse sensitivity
    public float smoothing = 2.0f;

    GameObject character;

    //parent camera under character to unify their movements together
    //characeter's body movement parallels the camera
    void Start ()
    {
        character = this.transform.parent.gameObject;
	}
	
	// smooth down movement and jerkiness of camera
	void Update ()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")); //gets change of mouse movement since last update

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing) ;
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing) ;
        mouseLook += smoothV;

        //emable camera's vertical and horizontal rotation
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);

        mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);
        mouseLook += smoothV;

    }
}
