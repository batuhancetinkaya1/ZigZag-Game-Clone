using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPointHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float fallTime = 0.1f;
    [SerializeField] private float deathTime = 5f;

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Sphere"))
        {
            StartCoroutine(CubeFallDown());
            StartCoroutine(DestroyMe());
        }
    }
    public IEnumerator CubeFallDown()
    {
        yield return new WaitForSeconds(fallTime);
        rb.useGravity = true;
        rb.isKinematic = false;
    }

    private IEnumerator DestroyMe()
    {
        yield return new WaitForSeconds(deathTime);
        Object.Destroy(this.gameObject);
    }
}
