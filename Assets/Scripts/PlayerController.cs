using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    void OnMove(InputValue movementValue)
    {
        // Function body
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = -1 * movementVector.x;
        movementY = -1 * movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    void OnGUI()
    {
        if (rb.position.z >= 17 && rb.position.z <= 23 && rb.position.x <= -21 && rb.position.x >= -25)
        {
            if (GUI.Button(new Rect(200, 200, 800, 400), "You are win!\nExit"))
            {
                Application.Quit();
            }
            Time.timeScale = 0;
        }
    }
}
