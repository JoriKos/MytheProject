using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    private float gravity = -10f;
    Vector3 targetDir;
    Vector3 bodyUp;

    public void Attract(Transform body, Rigidbody rb) //Attracts gameobjects. Is public because protected won't work because lol why bother working when you can just not work, screw you C#
    {
        targetDir = (body.position - transform.position).normalized;
        bodyUp = body.up;

        body.rotation = Quaternion.FromToRotation(body.up, targetDir) * body.rotation;
        rb.AddForce(targetDir * gravity);
    }
}
