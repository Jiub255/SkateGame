using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltoRipoffRipoffMovement : MonoBehaviour
{
	[Header("Movement Stats"), SerializeField]
	private float speed = 20f;
	[SerializeField]
	private float rotationSpeed = 1.5f;
	[SerializeField]
	private float backwardsRotationSpeed = -1f;
	[SerializeField]
	private float jumpForce = 10f;
	[SerializeField]
	private float boostSpeed;

	private bool isGrounded = true;
	private bool moving = false;
	private bool hitGround = false;

	[Header("Sprites"), SerializeField]
	private Sprite normalSprite;
	[SerializeField]
	private Sprite crouchedSprite;
	[SerializeField]
	private Sprite jumpingSprite;
	//???
	public GameObject sprites;

	private SpriteRenderer spriteRenderer;
	private Rigidbody2D rb;


	[Header("???")]
	[SerializeField]
	GameObject particleEffect; // For trailing dust/wind or whatever
	[SerializeField]
	GameObject loseState;
	[SerializeField]
	GameObject cam;
	[SerializeField]
	GameObject looseUI;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
		rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
		spriteRenderer.sprite = normalSprite;
    }

    private void Update()
    {
        // use old input for now
		if (Input.GetKeyDown(KeyCode.Space))
        {
			moving = true;
        }
		if (Input.GetKeyUp(KeyCode.Space))
        {
			moving = false;
        }
    }

    private void FixedUpdate()
    {
        if (isGrounded)
        {
			spriteRenderer.sprite = normalSprite;
			particleEffect.SetActive(true);
        }
        else
        {
			particleEffect.SetActive(false);
        }

		if (!hitGround)
        {
			rb.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force); // should it really be deltaTime?
        }


		if (moving)
        {
			if (!isGrounded)
            {
				rb.AddTorque(rotationSpeed * rotationSpeed, ForceMode2D.Force);
				spriteRenderer.sprite = crouchedSprite;
            }
            else
            {
				rb.AddForce(transform.up * jumpForce * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
        }
        else // if (!moving)
        {
			if (!isGrounded)
            {
				spriteRenderer.sprite = jumpingSprite;
				rb.AddTorque(backwardsRotationSpeed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
		isGrounded = true;
		spriteRenderer.sprite = normalSprite;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
		isGrounded = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boost"))
        {
			rb.AddForce(transform.right * boostSpeed, ForceMode2D.Impulse);
        }
		if (collision.CompareTag("Ground"))
        {
			hitGround = true;
			loseState.transform.position = transform.position;
			Instantiate(loseState);
			Destroy(gameObject);
			cam.SetActive(false);
			looseUI.SetActive(true);
        }
		if (collision.CompareTag("Rock"))
        {
			hitGround = true;
			loseState.transform.position = transform.position;
			Instantiate(loseState);
			Destroy(gameObject);
			cam.SetActive(false);
			looseUI.SetActive(true);
		}
    }

}