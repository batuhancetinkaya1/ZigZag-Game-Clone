using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Movement : MonoBehaviour
{
    public GameObject sphere;
    private Rigidbody rb;
    public float speed = 0.5f;

    [SerializeField] public bool isAlive = true;
    private Vector3 startPoint;
    private bool currentDirection; // true = left, false = right

    [SerializeField] private GameManager gameManager;

    void Start()
    {
        Time.timeScale = 1;
        rb = sphere.GetComponent<Rigidbody>();
        startPoint = sphere.transform.position;
        currentDirection = Random.Range(0, 2) == 0;
        MoveSphere(currentDirection);
    }

    void Update()
    {
        if (!CheckPositionY())
        {
            StartCoroutine(gameManager.HandleDeath());
            return;
        }

        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.anyKeyDown)
        {
            currentDirection = !currentDirection;
        }

        MoveSphere(currentDirection);
    }

    private void MoveSphere(bool direction)
    {
        rb.velocity = direction
            ? speed * new Vector3(-1, 0, 0) // Move left
            : speed * new Vector3(0, 0, -1); // Move right
    }

    private bool CheckPositionY()
    {
        isAlive = sphere.transform.position.y > 1f;
        return isAlive;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Cube"))
        {
            Cube cube = collision.collider.GetComponent<Cube>();
            cube.StartCoroutine(cube.CubeFallDown());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Cube"))
        {
            gameManager.IncreaseScore();
        }
    }

}
