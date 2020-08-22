using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    [SerializeField]
    Stage stage;
    [SerializeField]
    int ClearIndex = 0;
    public int clearINdex
    {
        get { return ClearIndex; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Clear"))
        {
            //GetComponent<RectTransform>().position = collision.GetComponent<RectTransform>().position;
            Debug.Log("Hit");
            if (collision.GetComponent<Drag>().index == ClearIndex)
            {
                stage.ClearFlag = true;
            }
        }
    }
}
