using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject target; // Referans Sphere
    [SerializeField] private Vector3 offset;    // Normal takip ofseti
    [SerializeField] private Vector3 deathCamOffset; // Ölüm pozisyonu için ofset
    [SerializeField] private float transitionSpeed = 5f;
    [SerializeField] private Sphere_Movement sphereMovement;

    private void Start()
    {
        sphereMovement = target.GetComponent<Sphere_Movement>();
    }

    void LateUpdate()
    {
        CameraMove();
    }

    private void CameraMove()
    {
        if (sphereMovement.isAlive)
        {
            transform.position = target.transform.position + offset;
        }
        else if (!sphereMovement.isAlive)
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + deathCamOffset, Time.deltaTime * transitionSpeed);
        }
    }
}

