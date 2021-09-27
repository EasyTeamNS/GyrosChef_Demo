using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoTableManager : MonoBehaviour
{

    public DragObjects dragObjects;

    // Start is called before the first frame update
    void Start()
    {
        dragObjects = Transform.FindObjectOfType<DragObjects>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("");
        //dragObjects.GetComponent<DragObjects>().DragObjectDisabled(gameObject);
        // pozvati animaciju krompira do masine
    }
}
