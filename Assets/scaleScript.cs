using System.Collections;
using System.Collections.Generic;
using Unity.Hierarchy;
using UnityEngine;

public class scaleScript : MonoBehaviour
{
    public float x = 1f;
    public float y = 1f;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //time += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.W))
        {
            time++;
            if (time >= 0 && time < 50)
            {
                x++;
                y++;
                transform.localScale = new Vector2(x, y); 
            }
        }
    }
}
