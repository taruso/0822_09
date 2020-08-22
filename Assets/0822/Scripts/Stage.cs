using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    [SerializeField]
    Animator animator = null;
    [SerializeField]
    GameObject ClearContainer = null;
    [SerializeField]
    GameObject MissContainer = null;

    private bool clearFlag = false;
    public bool ClearFlag
    {
        get { return clearFlag; }
        set { clearFlag = value; }
    }


    // Start is called before the first frame update
    void Start()
    {
        animator.speed = 0.0f;
        ClearContainer.SetActive(false);
        MissContainer.SetActive(false);
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
        else
        {
            MissContainer.SetActive(true);
        }
    }

    private IEnumerator Clear()
    {
        yield return new WaitForSeconds(2.5f);
        ClearContainer.SetActive(true);
    }
}
