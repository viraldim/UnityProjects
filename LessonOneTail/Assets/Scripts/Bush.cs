using UnityEngine;

public class Bush : MonoBehaviour
{
    public float speed = 10;
    public Transform cam;

    void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (Input.GetKey(KeyCode.W))
	    {
	        transform.Translate(0f, speed * Time.deltaTime, 0f);
	    }
	    if (Input.GetKey(KeyCode.A))
	    {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
	    }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -speed * Time.deltaTime, 0f);
        }
	}

    void LateUpdate()
    {
        cam.position = new Vector3(
            transform.position.x+10f,
            transform.position.y+10f,
            transform.position.z-55f);
    }
}
