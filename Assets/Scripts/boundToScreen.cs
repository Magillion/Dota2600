using UnityEngine;
/*
 * Binds the player to the screen
 */

public class boundToScreen : MonoBehaviour {

    void LateUpdate() //Called after all the other update functions
    {
        var left = Camera.main.ViewportToWorldPoint(Vector3.zero).x; //Left bound of main camera
        var right = Camera.main.ViewportToWorldPoint(Vector3.one).x; //Right bound of main camera
        var top = Camera.main.ViewportToWorldPoint(Vector3.zero).y; //Top bound of main camera
        var bottom = Camera.main.ViewportToWorldPoint(Vector3.one).y; //Bottom bound of main camera

        float x = transform.position.x, y = transform.position.y; // Current Player position

        //Left and right checks against main camera bounds
        if (transform.position.x < left + GetComponent<Renderer>().bounds.extents.x)
        {
            x = left + GetComponent<Renderer>().bounds.extents.x;
        }
        else if (transform.position.x > right - GetComponent<Renderer>().bounds.extents.x)
        {
            x = right - GetComponent<Renderer>().bounds.extents.x;
        }

        //Top and bottom checks against main camera bounds
        if (transform.position.y <= top + GetComponent<Renderer>().bounds.extents.y)
        {
            y = top + GetComponent<Renderer>().bounds.extents.y;
        }
        else if (transform.position.y >= bottom - GetComponent<Renderer>().bounds.extents.y)
        {
            y = bottom - GetComponent<Renderer>().bounds.extents.y;
        }
        transform.position = new Vector3(x, y, transform.position.z);
    }//End of lateupdate
}
