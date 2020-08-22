using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class moji : MonoBehaviour, IDragHandler
{
    [SerializeField]
    RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
 
        rectTransform.position += new Vector3(eventData.delta.x * 0.1f, eventData.delta.y * 0.1f, 0f);

    }
}
