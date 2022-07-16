using UnityEngine;

public class playermovement : MonoBehaviour
{
	[SerializeField] private float speed;
	private Rigidbody2D body;
	private Animator anim;



	private void Awake() {
		//grab reference shit idk
		body = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}



	private void Update() {
		

		float xInput = Input.GetAxis("Horizontal");
		body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

		//flipping sprite based on player x movement
		if(xInput> 0.01f)
			transform.localScale = new Vector3(5, 5, 5);
		else if(xInput< -0.01f)
			transform.localScale = new Vector3(-5, 5, 5);

		if(Input.GetKey(KeyCode.Space))
			body.velocity = new Vector2(body.velocity.x, speed);


		//set anim perameters
		anim.SetBool("run", xInput != 0);



	}
}
