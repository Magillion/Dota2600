using UnityEngine;
/*
 * Moves the Player in X and Y
 */

[RequireComponent(typeof(Rigidbody))] //Throws error if no rigidBody is attached
public class Movement : MonoBehaviour
{
    //Public variables
    public float speed = 10f;
    public string playerNumber;

    //Private variables
    private new Rigidbody2D rigidbody2D;
    private Vector2 axisMovement;
    private Vector3 newPos;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    } //End of start

    private void FixedUpdate() //Physics2d attached
    {
        
        float horizontal = Input.GetAxis("Horizontal " + playerNumber) * speed * Time.deltaTime; //Name the axis and player number 1,2,3,4 etc to allocate player to controller or player won't move
        float vertical = Input.GetAxis("Vertical " + playerNumber) * speed * Time.deltaTime;

        axisMovement = new Vector2(horizontal, vertical);

        newPos = rigidbody2D.position + axisMovement;

        rigidbody2D.MovePosition(newPos);
       
    } //End of FixedUpdate.
}
