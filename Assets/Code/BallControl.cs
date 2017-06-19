using UnityEngine;

public class BallControl : MonoBehaviour
{
	void Start()
	{
        float StartDirection = Random.Range(0, 2);

        if (StartDirection <= 0.5)
        {
            Debug.Log("Shoot Right");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 7));
        }
        else
        {
            Debug.Log("Shoot Left");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, -7));
        }
	}

	void OnCollisionEnter2D(Collision2D colInfo)
	{
        Rigidbody2D Ball = GetComponent<Rigidbody2D>();

        if (colInfo.collider.tag == "Player")
        {
            Ball.velocity = new Vector2(Ball.velocity.x, Ball.velocity.y / 2 + colInfo.collider.GetComponent<Rigidbody2D>().velocity.y / 3);

        }
	}
}