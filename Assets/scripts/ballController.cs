using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public float speed = 5.0f;
    public float horizontalInput;
    public float verticalInput;
    private Rigidbody rg;
    GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();

        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 roller = new Vector3(horizontalInput, 0, verticalInput);
        rg.AddForce(roller * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collided");
            gameController.hasGameStarted = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            gameController.score++;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Collided");
            gameController.hasGameStarted = false;
        }
    }
}
