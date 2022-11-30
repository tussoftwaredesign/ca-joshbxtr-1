using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ZombieRag : MonoBehaviour
{
    public BoxCollider mainCollider;
    public GameObject rig;
    public Rigidbody rb;
    public NavMeshAgent nav;
    public EnemyFollow follow;
    public AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
        GetRagdollBits();
        ragdollOff();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Weapon")
        {
            ragdollOn();
            Debug.Log("Ragdoll On");
        }
    }

    public Collider[] ragdollColliders;
    Rigidbody[] limbsRigidbodies;
    void GetRagdollBits()
    {
        ragdollColliders = rig.GetComponentsInChildren<Collider>();
        limbsRigidbodies = rig.GetComponentsInChildren<Rigidbody>();
    }

    void ragdollOn()
    {
        foreach (Collider collider in ragdollColliders)
        {
            collider.enabled = true;
        }

        foreach(Rigidbody rigid in limbsRigidbodies)
        {
            rigid.isKinematic = false;
        }

        audio.enabled = false;
        follow.enabled = false;
        nav.enabled = false;
        mainCollider.enabled = false;
        rb.isKinematic = true;
    }

    void ragdollOff()
    {
        foreach(Collider col in ragdollColliders)
        {
            col.enabled = false;
        }

        foreach(Rigidbody rigid in limbsRigidbodies)
        {
            rigid.isKinematic = true;
        }

        mainCollider.enabled = true;
        rb.isKinematic = false;
    }


    // Update is called once per frame
    void Update()
    {

    }
}
