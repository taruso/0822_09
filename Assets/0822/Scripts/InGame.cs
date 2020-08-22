using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGame : MonoBehaviour
{
    [SerializeField]
    Stage[] Stages = null;

    private string StageNum_Key = "StageNum";
    //private int stageNum = 0;
    public int StageNum
    {
        get { return PlayerPrefs.GetInt(StageNum_Key, 0); }
        set { PlayerPrefs.SetInt(StageNum_Key, value); }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Stages[StageNum].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveButton()
    {
        Stages[StageNum].StartAnimator();
    }

    public void StageAdd()
    {
        StageNum = (StageNum + 1) % Stages.Length;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
