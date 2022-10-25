using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Limb : MonoBehaviour
{
    public bool fatal = false;

    public void Hit()
    {
        transform.localScale = Vector3.zero;

        if (fatal)
            GetComponentInParent<Zombie>().Death();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
            Hit();
    }

    // Start is called before the first frame update
    void Start()
    {
        //..
    }

    // Update is called once per frame
    void Update()
    {
        //..
    }
}
