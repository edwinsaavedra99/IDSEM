using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
[System.Serializable]
public class DropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");

        if (!this.item)
        {
            this.item = DragDrop.itemDragging;
            this.item.transform.SetParent(transform);
            this.item.transform.position = transform.position;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if(this.item != null && this.item.transform.parent != transform )
      {
            Debug.Log("Remover");
            this.item = null;
        }
    }
}
