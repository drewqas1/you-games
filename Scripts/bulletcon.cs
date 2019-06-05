using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class bulletcon : MonoBehaviour
{
  public Text scoreText;
  static int score = 0;
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }
      void OnCollisionEnter(Collision other)
        {
 
           if(other.gameObject.tag == "Enemy")
           {
           		Destroy(other.gameObject);
                Destroy(gameObject);
                score = score + 1;
        scoreText.text = "score:" + score;
           	  
           }
              if(score >= 3)
          {
           SceneManager.LoadScene(0);
           score = 0;
          }
        }
   		
}

          
  