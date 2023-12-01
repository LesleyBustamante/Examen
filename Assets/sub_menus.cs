using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class sub_menus : MonoBehaviour
{
     Button bttn_1_1, bttn_1_2, bttn_1_3, bttn_1_4;
      Button bttn_2_1, bttn_2_2, bttn_2_3, bttn_2_4;
     
     GameObject go;
     bool status;
    

    // Start is called before the first frame update
    void Start()
    {
       
        bttn_1_1 = GameObject.Find("Limon").GetComponent<Button>();
         bttn_1_2 = GameObject.Find("Cerezo").GetComponent<Button>();
          bttn_1_3 = GameObject.Find("Peral").GetComponent<Button>();
           bttn_1_4 = GameObject.Find("Granada").GetComponent<Button>();
           
         bttn_2_1 = GameObject.Find("Trigo").GetComponent<Button>();
          bttn_2_2 = GameObject.Find("Fresas").GetComponent<Button>();
           bttn_2_3 = GameObject.Find("Papa").GetComponent<Button>();
            bttn_2_4 = GameObject.Find("Maiz").GetComponent<Button>();  
       
        bttn_1_1.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Tree_Lemon_Grown_01")));             
         bttn_1_2.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Tree_Cherry_01")));
          bttn_1_3.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Tree_Pear_01")));
           bttn_1_4.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Tree_Plum_01")));
           
           bttn_2_1.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Plant_Wheat_04")));
            bttn_2_2.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Plant_Strawberry_01")));
             bttn_2_3.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Potato_02")));
              bttn_2_4.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Plant_Corn_01")));
                    
              status = false;
     
    }  
   
       
   // Update is called once per frame
    void Update()
    {
          if (Input.GetMouseButtonDown(0) && status) 
          {
           
           Camera cmr = GameObject.Find("Camera").GetComponent<Camera>(); 
           Vector3 mouse_pstn = cmr.ViewportToWorldPoint(new Vector3(Input.mousePosition.x/Screen.width,0f,6f));
           Vector3 objt_pstn = new Vector3(mouse_pstn.x,0f,mouse_pstn.z);
           Instantiate(go,objt_pstn, Quaternion.identity);   
           
          }     
                                                      
    }                                            
      
     
                         
    GameObject select_go(GameObject game_object) 
    { 
    go = game_object; 
    status = true;
    return go;
    }
    
    
  }
   
           
         
           
           
           
         
            
          
                         
        
    

    
   
    






