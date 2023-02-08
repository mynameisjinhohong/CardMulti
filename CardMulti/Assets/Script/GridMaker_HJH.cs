using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMaker_HJH : MonoBehaviour
{
    Camera cam;
    public GameObject grid;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        Vector3 leftBottom = cam.ScreenToWorldPoint(new Vector3(0, 0, 9));
        Vector3 rightTop = cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, cam.pixelHeight, 9));
        float xTerm = (rightTop.x - leftBottom.x) / 4;
        float yTerm = (rightTop.y - leftBottom.y) / 9;
        float yStart = leftBottom.y + (yTerm * 3);
        float xStart = leftBottom.x;
        for(int i =0; i<4; i++)
        {
            for(int j =0; j<3; j++)
            {
                GameObject gr = Instantiate(grid);
                gr.transform.position = new Vector3(xStart + (xTerm * i), yStart + (yTerm * j), -1);
                gr.transform.localScale = new Vector3(xTerm, yTerm, 1);
                //gr.transform.parent = gameObject.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
