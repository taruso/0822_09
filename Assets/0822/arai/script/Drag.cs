using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IDragHandler
{
   
    [SerializeField]
    int Index = 0;
    public int index
    {
        get { return Index; }
    }

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position = Input.mousePosition;
    }

    public void OnDrag(PointerEventData data)
    {
        //Vector3 TargetPos = Camera.main.ScreenToWorldPoint(data.position);
        //TargetPos.z = 0;
        //transform.position = TargetPos;

        //// クリックしたスクリーン座標
        //var screenPoint = Input.mousePosition;

        //// Canvasにセットされているカメラを取得
        //var graphic = GetComponent<Graphic>();
        //var camera = graphic.canvas.worldCamera;

        //// Overlayの場合はScreenPointToLocalPointInRectangleにnullを渡さないといけないので書き換える
        //if (graphic.canvas.renderMode == RenderMode.ScreenSpaceOverlay)
        //{
        //    camera = null;
        //}

        //// クリック位置に対応するRectTransformのlocalPositionを計算する
        //var localPoint = Vector2.zero;
        //RectTransformUtility.ScreenPointToLocalPointInRectangle(graphic.rectTransform, screenPoint, camera, out localPoint);

        //GetComponent<RectTransform>().localPosition = localPoint;
        GetComponent<RectTransform>().position += new Vector3(data.delta.x * 0.1f, data.delta.y * 0.1f, 0);
    }

   

}
