using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {
	
	public string name;

	void OnGUI () {
		
		GUI.Box(new Rect(500,100,250,109), name);
		
		if(GUI.Button(new Rect(500,100,50,50), " Voltar ")){
		
			Application.LoadLevel("menu");
		
		}
		
     
    }
	
}
 
