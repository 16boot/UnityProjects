using UnityEngine;
using System.Collections;

public class controls : MonoBehaviour {
	
	

	//rotation 
	void TranslateR (float speed){
		
		if(Input.GetKey("j")){
		transform.Rotate(0,speed,0);
		}if(Input.GetKey("l")){
		transform.Rotate(0,-speed,0);
		}
	}
	//Translation  
	void TranslateP (float speed){
		
		if(Input.GetKey("w")){
		transform.Translate(0,0,speed);
	
		}else if(Input.GetKey("s")){
		transform.Translate(0,0,-speed);
		
		}else if(Input.GetKey("a")){
		transform.Translate(speed,0,0);
		
		}else if(Input.GetKey("d")){
		transform.Translate(-speed,0,0);
		}
		 if(Input.GetKey("space")){
		transform.Translate(0,speed,0);
			
		}if(Input.GetKey("p")){
		
	  }
	}
	
	
	// Update is called once per frame
	void Update () {
		
		float velocidade  = 10 * Time.deltaTime;
		float velocidadeR = 100 * Time.deltaTime;
		
		TranslateP(velocidade);
		TranslateR(velocidadeR);
		
	}
}
