using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 mOffset;
    private float potatoZAxis;
    //private float mXCoord;
    public bool canMoveObject;

    //private double postatoZ = 1.457171;
    private float potatoStartY;

    private PotatoTableColliderManager colliderManager;


    void Start()
    {
        colliderManager = Transform.FindObjectOfType<PotatoTableColliderManager>();
        potatoStartY = transform.position.y;
        canMoveObject = true;
    }

    void Update()
    {
        //Debug.Log(canMoveObject);
    }

    void OnMouseDown()
    {
        potatoZAxis = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        //mXCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).x; // za zakljucavanje pomeranja po osama
        mOffset = transform.position - GetMousePos();
        colliderManager.GetComponent<PotatoTableColliderManager>().StartDrag();
    }

    void OnMouseUp()
    {
        DragObjectEnabled();
        colliderManager.GetComponent<PotatoTableColliderManager>().StopDrag();
        MoveObjectToEndPosition();
    }

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
        cursorPos.z = potatoZAxis;
        //cursorPos.x = mXCoord;
        return Camera.main.ScreenToWorldPoint(cursorPos);
    }

    public void DragObjectEnabled()
    {
        canMoveObject = true;
        //Debug.Log(canMoveObject + " enabled");
    }

    public void DragObjectDisabled(GameObject g)
    {
        canMoveObject = false;
        //Debug.Log(canMoveObject + " disabled");
    }

    public void MoveObjectToEndPosition()
    {

    }
}
