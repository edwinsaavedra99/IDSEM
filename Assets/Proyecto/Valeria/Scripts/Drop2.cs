using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop2 : MonoBehaviour
{
    public GameObject correctForm;
    private bool moving;
    // Start is called before the first frame update

    private float startPosX;
    private float startPosY;
    void Start()    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
        }
    }
    private void onMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            moving = true;
        }
    }
    private void onMouseUp()
    {
        moving = false;
    }
}
