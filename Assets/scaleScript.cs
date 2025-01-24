using System.Collections;
using System.Collections.Generic;
using Unity.Hierarchy;
using UnityEngine;

public class scaleScript : MonoBehaviour
{
    public GameObject Circle;
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
        while (time >= 0 && time < 100)
        {
            time++;
            x *= Time.deltaTime + 1;

            y *= Time.deltaTime + 1;
            transform.localScale = new Vector2(x/100, y/100); 
        }
        time = 0;
        
    }
    public void Run()
    {
        Update();
    }
}
