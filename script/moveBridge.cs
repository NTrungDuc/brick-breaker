using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBridge : MonoBehaviour
{
    public float minX;
    public float maxX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.position = GetMousePosition();
        } 
    }
    Vector3 GetMousePosition()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.x=Mathf.Clamp(mousePos.x, minX, maxX);
        mousePos.y = transform.position.y;
        mousePos.z = 0;
        return mousePos;
    }
}
