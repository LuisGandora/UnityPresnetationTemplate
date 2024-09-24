using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsFall : MonoBehaviour, Acrionable
{
    public GameObject cubeOne;
    public GameObject cubeTwo;
    public Rigidbody rb;

    public void Awake(){
        rb.isKinematic = true;
        cubeOne.GetComponent<Rigidbody>().isKinematic = true;
        cubeTwo.GetComponent<Rigidbody>().isKinematic = true;
        rb.useGravity = false;
        cubeOne.GetComponent<Rigidbody>().useGravity  = false;
        cubeTwo.GetComponent<Rigidbody>().useGravity  = false;
        cubeOne.SetActive(false);
        cubeTwo.SetActive(false);
    }

    public void playAction(){
        cubeOne.SetActive(true);
        cubeTwo.SetActive(true);
        rb.isKinematic = false;
        cubeOne.GetComponent<Rigidbody>().isKinematic = false;
        cubeTwo.GetComponent<Rigidbody>().isKinematic = false;
        rb.useGravity = true;
        cubeOne.GetComponent<Rigidbody>().useGravity  = true;
        cubeTwo.GetComponent<Rigidbody>().useGravity  = true;
        
    }
}
