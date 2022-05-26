using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 1 - Start
using UnityEngine.UI;
// 1 - End
public class Basket : MonoBehaviour
{
// 2 - Start
    [Header("Set Dynamically")]
    public Text scoreGT;
// 2 - End

// 3 - Start | все строки внутри метода Start()
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }
// 3 - End
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
        }
// 4 - Start
        int score = int.Parse(scoreGT.text);
        score += 100;
        scoreGT.text = score.ToString();
// 4 - End
// 1 - Start
        if (score > HighScore.score)
        {
            HighScore.score = score;
        }
// 1 - End

    }
}



