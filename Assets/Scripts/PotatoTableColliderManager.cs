using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoTableColliderManager : MonoBehaviour
{

    private DragObjects dragObjects;

    private bool dragging;


    // Start is called before the first frame update
    void Start()
    {
        dragObjects = Transform.FindObjectOfType<DragObjects>();
    }
    // /*

    void Update()
    {
        
    }

    public void StartDrag()
    {
        dragging = true;
    }

    public void StopDrag()
    {
        dragging = false;

    }
    // */

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Drag object: " + other.name + " and the collider is: " + this.name);
        dragObjects.GetComponent<DragObjects>().DragObjectDisabled(gameObject);
        // pozvati animaciju krompira do masine
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (dragging)
        {
             Debug.Log("And the collider name: " + this.name);
            dragObjects.GetComponent<DragObjects>().DragObjectDisabled(gameObject);
        }
    }
}
