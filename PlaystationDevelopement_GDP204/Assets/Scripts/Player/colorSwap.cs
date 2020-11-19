using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorSwap : MonoBehaviour
{
    private RawImage image;
    public float timer;
    private Vector3 newColor;
    private Vector3 curentColor;
    public float speed = 1;

    void Start()
    {
        image = gameObject.GetComponent<RawImage>();
        image.color = Color.white;
        curentColor = new Vector3(1, 1, 1);
        newColor = new Vector3(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > speed)
        {
            // pick new color
            curentColor = new Vector3(image.color.r, image.color.g, image.color.b);
            newColor = new Vector3(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
            timer = 0;
        }
        else
        {
            float r = Mathf.Lerp(curentColor.x, newColor.x, timer / speed);
            float g = Mathf.Lerp(curentColor.y, newColor.y, timer / speed);
            float b = Mathf.Lerp(curentColor.z, newColor.z, timer / speed);

            image.color = new Color(r, g, b, 1);
            timer += Time.deltaTime;
        }
    }
}
