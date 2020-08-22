using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    [SerializeField]
    Animator animator = null;
    [SerializeField]
    GameObject ClearContainer = null;

    public bool ClearFlag = false;


    // Start is called before the first frame update
    void Start()
    {
        animator.speed = 0.0f;
        ClearContainer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ClearFlag = true;
            StartAnimator();
        }
    }

    public void StartAnimator()
    {
        if (ClearFlag)
        {
            animator.speed = 1.0f;
            StartCoroutine(Clear());
        }
    }

    private IEnumerator Clear()
    {
        yield return new WaitForSeconds(2.5f);
        ClearContainer.SetActive(true);
    }
}
