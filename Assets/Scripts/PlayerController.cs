using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float input;
    private float speed = 10f;

    private float score = 0.0f;
    public Text scoreText;
    
    public Text gameOverText;

    public AudioSource backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.enabled = false;
        rb = GetComponent<Rigidbody2D>();

        // Background music
        backgroundMusic = GetComponent<AudioSource>();
        backgroundMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        // Flip sprite when facing left or right
        if (input < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

        // Score logic
        if (rb.velocity.y > 0 && transform.position.y > score)
        {
            score = transform.position.y;
        }

        scoreText.text = "Score: " + Mathf.Round(score).ToString();

        // Game Over logic
        if (rb.velocity.y < 0 && transform.position.y < score - 10)
        {
            gameOverText.enabled = true;
        }
    }

    void FixedUpdate()
    {
        input = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }
}