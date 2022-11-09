using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBg : MonoBehaviour
{

    private float time = 0.0f;
    float speed;
    float width;
    float height;
    public Image background;


    void Start()
    {

        width = 100;
        height = 100;

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float x = Mathf.Cos(time) / width;
        float y = Mathf.Sin(time) / height;
        float z = 0;

        background.transform.localPosition -= new Vector3(x, y, z);


    }
}
