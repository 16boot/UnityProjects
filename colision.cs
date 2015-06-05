using UnityEngine;
using System.Collections;

public class colision : MonoBehaviour {

 	void OnCollisionEnter (Collision col){
        
		if(col.gameObject.name == "player"){
			
		Application.LoadLevel("win");
       
		}
    }
} 
