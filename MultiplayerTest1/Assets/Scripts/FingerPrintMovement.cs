using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerPrintMovement : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);  
        this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Vibrate");
        Handheld.Vibrate();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Vibrate");
        Handheld.Vibrate();
    }
}
