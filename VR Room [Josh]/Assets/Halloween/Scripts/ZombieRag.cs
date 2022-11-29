using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody[] bodies = GetComponentsInChildren<Rigidbody>();

        foreach (var b in bodies)
            b.isKinematic = true;
    }

    public void Kill()
    {
        Rigidbody[] bodies = GetComponentsInChildren<Rigidbody>();

        foreach (var b in bodies)
            b.isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
