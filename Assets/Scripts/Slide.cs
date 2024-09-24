using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public bool isFinished;
    public List<GameObject> Actions;
    public int i;

    void Awake(){
        i = -1;
        
    }
    

    // Update is called once per frame
    void Update()
    {

        if(i >= Actions.Count || Actions == null || Actions.Count == 0){
            isFinished = true;
        }
        if(i >= 0 && !isFinished){
            for(int j = 0; j < Actions.Count; j++){
                if(Actions[i] != Actions[j] && !isFinished && Actions[i] != null && Actions[j] != null){
                    Actions[j].SetActive(false);
                }
                else if(Actions[i] != null){
                    Actions[i].SetActive(true);
                    if(Actions[i].GetComponent<Acrionable>() != null){
                        Actions[i].GetComponent<Acrionable>().playAction();
                        Debug.Log("" + Actions[i]);
                    }
                    else{
                        Debug.Log("HEy");
                    }
                }
            }
        }
    }

    public void plusActions(){
        // Actions[i] Go through each animation or tilemap or opacity script and then run it if it isnt null
        if(Actions[i].GetComponent<Animator>() != null){}
        i++;
        
    }
}
