using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable_on_target_hit : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            ScoreManager.instance.AddScore(score);
        }
    }
}
