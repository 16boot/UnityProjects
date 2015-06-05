using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	
	public string[] name_button_add;

	void OnGUI () {
		
		if(GUI.Button(new Rect(500,100,80,20), name_button_add[0])) {
          Application.LoadLevel("game");
        
			}
		if(GUI.Button(new Rect(500,150,80,20), name_button_add[1])) {
		  Application.Quit();
        
		}
		 if(GUI.Button(new Rect(500,200,80,20), name_button_add[2])) {
       	  Application.LoadLevel("creditos");
        
		}
     
    }
}
