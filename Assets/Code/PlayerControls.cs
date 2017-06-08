using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed = 5f;
    
	void Update ()
    {
		if (Input.GetKey(moveUp))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
	}
}