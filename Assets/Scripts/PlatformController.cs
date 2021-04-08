using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Rigidbody2D player = other.gameObject.GetComponent<Rigidbody2D>();
        // Check if the player is moving downward
        if (player.velocity.y <= 0)
        {
            player.AddForce(Vector3.up * 400f);
        }
    }
}
