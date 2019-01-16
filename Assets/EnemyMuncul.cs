using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMuncul : MonoBehaviour {
    [SerializeField]
    private GameObject enemy;
    private GameObject player;
    GameObject[] monster;
    float timer = 0;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    //update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3f)
        {
            Vector3 posRecomended;
            do
            {
                posRecomended = new Vector3(Random.Range(0, 500), 50, Random.Range(0, 500));
            }
            while (Vector3.Distance(posRecomended, player.transform.position) < 50f);
            Instantiate(enemy, posRecomended, Quaternion.identity);
            timer = 0;
        }
    }
}
