using UnityEngine;

public class player : MonoBehaviour
{
    private int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Score:" + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);

        if (collision.gameObject.tag == "Coin")
        {
            score++;
            print("Coin Collected! Score:" + score);
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            print("YOU WIN! Final Score:" + score);
            Time.timeScale = 0f; // Stop the game
        }

    }
}
