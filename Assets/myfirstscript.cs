using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class myfirstscript : MonoBehaviour
{
    private float move = 0.01f;  // Declare move as a field with initial value for rightward movement

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TASK 1//
        //Have your object move continuously along the x, y, or z axis while in Play Mode.//
        transform.position+= new Vector3(move, 0f, 0f);
    
        //TASK 2//
        //When your object’s x, y, or z value goes beyond a certain amount, move the object in the opposite direction.//
        if (transform.position.x > 5f) move = -0.01f;
        if (transform.position.x < -5f) move = 0.01f; 
    
        //TASK 3//
        //Research about Rotations in Unity and perform Tasks 1 and 2 for rotation as well.//
        transform.Rotate(1, move, 1);
    }

}
