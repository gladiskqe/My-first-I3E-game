using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    int score = 0;

    GameObject currentCollidor;

    void OnCollisionEnter(Collision collision)
    {
       currentCollidor = collision.gameObject;
       print($"Collided with {currentCollidor.name}");
    }

    void OnCollisionExit(Collision collision)
    {
        currentCollidor = null;
        print($"Stopped colliding with {collision.gameObject.name}");

    }

    void OnInteract(InputValue value)
    {
        if (currentCollidor != null)
        {
            print($"Interacted with {currentCollidor.name}");
            var collectable = currentCollidor.GetComponent<Collectible>();
            if (collectable != null)
            {
                score += collectable.score;
                print($"Score: {score}");
                collectable.Collect();
            }

            var door = currentCollidor.GetComponent<Door>();
            if (door != null)
            {
                print("Interacted with door");
                door.Interact();
            }
        }
    }
}