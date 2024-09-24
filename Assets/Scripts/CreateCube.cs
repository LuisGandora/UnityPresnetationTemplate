using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour, Acrionable
{
    public GameObject cube;

    public void Awake(){
        cube.SetActive(false);
    }

    public void playAction(){
        cube.SetActive(true);
    }
}
