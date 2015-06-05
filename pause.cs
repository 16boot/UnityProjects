using System;
using UnityEngine;
 
 public class pause : MonoBehaviour{
     
	bool paused = false;
 
     void Update(){
        if(Input.GetKeyDown("q"))
             paused = Puase();
     }
     
     void OnGUI(){
         if(paused)
         {
			
			GUI.Box(new Rect(500,100,250,109), "pausado");
             if(GUI.Button(new Rect(500,100,80,20),"Continuar")){
                 paused = Puase();
			}
			 if(GUI.Button(new Rect(500,150,80,20),"menu")){
                 Application.LoadLevel("menu");
			}
			
			
         }
     }
 
     bool Puase(){
         if(Time.timeScale == 0f)
         {
             Time.timeScale = 1f;
             return(false);
         }
         else
         {
             Time.timeScale = 0f;
             return(true);    
         }
     }
 }
