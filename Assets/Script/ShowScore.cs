using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {
    public Text txScore;

    //update is called once per frame
    private void FixedUpdate()
    {
        GetComponent<Text>().text = Data.score.ToString();
    }
}
