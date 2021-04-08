using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        GameObject newPlatform = (GameObject)Instantiate(
                platformPrefab,
                new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f))),
                Quaternion.identity
            );
        Destroy(other.gameObject);
    }
}
