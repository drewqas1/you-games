using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cameracon : MonoBehaviour
{
   Rigidbody rb;
   GameObject bulletClone;
    Rigidbody rbClone;
    public GameObject bullet;
    public Text hpText;
    int hp;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
         hp = 3;
    }

 
    void Update()
    {
          float moveVertical = Input.GetAxis("Vertical");
       rb.AddForce(transform.forward * moveVertical *19f);

        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, moveHorizontal * 3f, 0);
        if(Input.GetKeyDown("space"))
        {
            bulletClone = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z),Quaternion.identity);
            rbClone = bulletClone.GetComponent<Rigidbody>();
            rbClone.AddForce(transform.forward * 1500f);
        }
    }
     void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            hp = hp -1;
            hpText.text = "hp:" + hp;
        }

        if(hp <= 0)
        {
          SceneManager.LoadScene(1);
          hp = 3;
        }
    }
}
