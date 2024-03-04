using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerSpeed;

    public KeyCode UpKey;
    public KeyCode DownKey;
    public KeyCode LeftKey;
    public KeyCode RightKey;

    private Rigidbody2D rig;

    public Collider2D escapePoint;

    public Canvas goCanvas;
    public Canvas esCanvas;

    public AudioSource dead;
    public AudioSource escape;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //get input
        Vector3 movement = GetInput();
        //move object
        MoveObject(movement);
    }

    private void OnCollisionEnter2D(Collision2D collision) //
    {
        if (collision.gameObject.name == "angry") // gak perlu ada bot 1,2,3
        {
            Time.timeScale = 0;
            goCanvas.enabled = true;

            dead.Play();
        }

        if (collision.collider == escapePoint)
        {
            Time.timeScale = 0;
            esCanvas.enabled = true;

            escape.Play();
        }
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(UpKey))
        {
            return Vector2.up * playerSpeed;
        }
        else if (Input.GetKey(DownKey))
        {
            return Vector2.down * playerSpeed;
        }
        else if (Input.GetKey(LeftKey))
        {
            return Vector2.left * playerSpeed;
        }
        else if (Input.GetKey(RightKey))
        {
            return Vector2.right * playerSpeed;
        }

        return Vector2.zero;
    }

    //move object
    private void MoveObject(Vector2 movement)
    {
        //Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }
}
