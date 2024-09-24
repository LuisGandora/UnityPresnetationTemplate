using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HideTillAction : MonoBehaviour, Acrionable
{
    public Image i;
    public TextMeshProUGUI t;

    public void Awake(){
        i.enabled = false;    
        if(t != null){
            t.enabled = false;        
        }
    }
    
    public void playAction(){
        i.enabled = true;
        if(t != null){
            t.enabled = true;       
        }    
    }
}
