using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_target_hit : MonoBehaviour
{
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
        if(col.gameObject.tag == "Bullet")
        {
            ScoreManager.instance.AddScore(10);
        }
    }
}
