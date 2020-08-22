using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchEventTest : MonoBehaviour, IPointerDownHandler
{
    private Drag mouse = null;

    // Start is called before the first frame update
    void Start()
    {
        mouse = GameObject.Find("Mouse").GetComponent<Drag>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData data)
    {
        //ここに処理を書く。
        //mouse.OnDrag(data);
        Debug.Log("タッチしたよー！");
    }
}
