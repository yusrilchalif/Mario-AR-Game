using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterMove : MonoBehaviour
{
    GameObject player;
    Animator animator;

    //use for intialization
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    //update call once per frame
    private void Update()
    {
        Data.score++;
        transform.LookAt(player.transform);
        transform.Translate(Vector3.forward * Time.deltaTime * 20f);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("gameover");
        }
        //if(collision.gameObject.tag.Equals)
    }
}
