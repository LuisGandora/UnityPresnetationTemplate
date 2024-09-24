using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour, Acrionable
{

    public GameObject cubePlayer;
    public bool isPlaying;

    public void playAction(){
        if(!isPlaying){
            StartCoroutine(movingProcess());
            isPlaying = true;
        }

        
    }

    public IEnumerator movingProcess(){
        yield return StartCoroutine(startMoving(3, 0));
        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(startMoving(-3, 0));
        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(startMoving(0, 3));
        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(startMoving(0, -3));


    }
    

    public IEnumerator startMoving(int x, int y){
        for(int i = 0; i < x; i++){
            cubePlayer.transform.position = new Vector3(transform.position.x + i, transform.position.y, transform.position.z);
            yield return new WaitForSeconds(0.01f);

        }
        for(int j = 0; j < y; j++){
            cubePlayer.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + j);
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(1f);
    }
    
}
