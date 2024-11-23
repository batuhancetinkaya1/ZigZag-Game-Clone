using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float fallTime =0.1f;

    public IEnumerator CubeFallDown()
    {
        yield return new WaitForSeconds(fallTime);
        rb.useGravity = true;
        rb.isKinematic = false;
    }

    public void CubeReset()
    {
        rb.useGravity = false;
        rb.isKinematic = true;
        transform.position = new Vector3(0, 0, 0);
    }
}
