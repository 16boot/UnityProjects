using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {
	
	 public GameObject destruct;
	
	void OnCollisionEnter (Collision col){
        
		if(col.gameObject.name == "player"){
			
				Destroy(destruct);
       
		}
    }
}
