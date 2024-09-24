using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideManager : MonoBehaviour
{
    public GameObject tempOne;
    public int index;
    public List<GameObject> slideList;
    // Start is called before the first frame update
    void Awake()
    {
        index =0;
        tempOne = slideList[index];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Debug.Log("UU");
            if(tempOne != null){
                if(tempOne.GetComponent<Slide>().isFinished) { 
                    plus();
                    Debug.Log("HEY");
                }
                else{
                    tempOne.GetComponent<Slide>().i++;
                }
            }
            else{
                plus();
                Debug.Log("GETTINGSLIDe");
            }
        }
        foreach (var item in slideList)
        {
            if(item != tempOne){
                item.SetActive(false);
            }
            else{
                item.SetActive(true);
            }
        }
    }

    private void plus(){
        index++;
        tempOne = slideList[index];
    }
}
