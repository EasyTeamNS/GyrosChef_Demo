using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoTableColliderManager : MonoBehaviour
{

    public DragObjects dragObjects;

    private bool dragging;

    // Start is called before the first frame update
    void Start()
    {
        dragObjects = Transform.FindObjectOfType<DragObjects>();
    }

    public void StartDrag()
    {
        dragging = true;
    }

    public void StopDrag()
    {
        dragging = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Drag object: " + other.name + " and the collider is: " + this.name);
        dragObjects.GetComponent<DragObjects>().DragObjectDisabled(gameObject);
        // pozvati animaciju krompira do masine
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Drag object: " + collision + " and the collider is: " + this.name);
        if (dragging)
        {
            dragObjects.GetComponent<DragObjects>().DragObjectDisabled(gameObject);
        }
    }
}
