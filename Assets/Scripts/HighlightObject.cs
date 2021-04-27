using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightObject : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    bool isHighlighted = false;
    bool canDrag = false;
    private Vector3 mOffset;
    private float mZCoord;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    void OnMouseEnter()
    {
        if ((gameObject.tag == "CanMove" || gameObject.tag == "Player") && isHighlighted == false)
        {
            rend.sharedMaterial = material[1];
            isHighlighted = true;
            canDrag = true;
        }
    }

    void OnMouseExit()
    {
        if ((gameObject.tag == "CanMove" || gameObject.tag == "Player") && isHighlighted == true)
        {
            rend.sharedMaterial = material[2];
            isHighlighted = false;
            canDrag = false;
        }
    }

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }
}
