using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 mOffset;
    private float mZCoord;
    private bool canMoveObject;


    void Start()
    {
        canMoveObject = true;
    }

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = transform.position - GetMousePos();
    }

    //void OnMouseUp()
    //{
     //   canMoveObject = false;
    //}

    void OnMouseDrag()
    {
        if (canMoveObject)
        {
            transform.position = GetMousePos() + mOffset;
        }
    }

    private Vector3 GetMousePos()
    {
        Vector3 cursorPos = Input.mousePosition;
        cursorPos.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(cursorPos);
    }

    public void DragObjectEnabled()
    {
        canMoveObject = true;
    }

    public void DragObjectDisabled(GameObject g)
    {
        canMoveObject = false;
    }
}
