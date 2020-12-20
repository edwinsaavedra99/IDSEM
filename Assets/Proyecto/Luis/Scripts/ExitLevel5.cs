using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitLevel5 : MonoBehaviour
{
    // Start is called before the first frame update
    public Button ButtonExitWin;
    public Button ButtonExitLose;
    void Start()
    {
        ButtonExitWin.onClick.AddListener(TaskOnclickExit);
        ButtonExitLose.onClick.AddListener(TaskOnclickExit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnclickExit(){
        SceneManager.LoadScene("Splash");
    }

}
