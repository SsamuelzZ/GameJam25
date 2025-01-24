using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    [SerializeField]
    int windCooldown = 30;
    [SerializeField]
    GameObject bubble;
    float size = 0;
    float increase = 0.01f;

    float timer = 0;
    Dictionary<string, int> wind = new Dictionary<string, int>();

    int x = 0;
    int y = 0;

    // Start is called before the first frame update
    void Start()
    {
        wind.Add("weak", 45); // 45% chance
        wind.Add("medium", 78); // 33% chance
        wind.Add("strong", 100); // 22% chance
    }


    void Update()
    {
        timer = Time.deltaTime;
        while (size < 100)
        {
            if(timer > 0.1)
            {
                size += increase * Time.deltaTime;
                gameObject.transform.localScale = new Vector3(size, size, size);

                timer = 0;
            }
            
        }
















        timer += Time.deltaTime;

        if( timer >= windCooldown)
        {
            int windOption = UnityEngine.Random.Range(0, wind.GetValueOrDefault("strong")+1);
            print(windOption);

            if (windOption <= wind.GetValueOrDefault("weak"))
            {
                x = UnityEngine.Random.Range(15, 30);
                y = UnityEngine.Random.Range(15, 30);
                gameObject.GetComponent<Transform>().rotation = new Quaternion(x, y, 0, 0);
                print(windOption);
                print("weak");
            }
            else if (windOption > wind.GetValueOrDefault("weak") && windOption <= wind.GetValueOrDefault("medium"))
            {
                x = UnityEngine.Random.Range(23, 49);
                y = UnityEngine.Random.Range(23, 49);
                gameObject.GetComponent<Transform>().rotation = new Quaternion(x, y, 0, 0);
                print(windOption);
                print("medium");
            }
            else if (windOption > wind.GetValueOrDefault("medium") && windOption <= wind.GetValueOrDefault("strong"))
            {
                x = UnityEngine.Random.Range(37, 80);
                y = UnityEngine.Random.Range(37, 80);
                gameObject.GetComponent<Transform>().rotation = new Quaternion(x, y, 0, 0);
                print(windOption);
                print("strong");
            }
            else
            {
                print("Error");
            }
            timer = 0;
        }
    }
}
