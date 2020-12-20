using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIcontroller : MonoBehaviour
{
    public Button ButtonBoy;
    public int gender=1;
    // Start is called before the first frame update
    void Start()
    {
        // niño 1, nina 2
        int avatar = PlayerPrefs.GetInt("Avatar",1);
        if(avatar == 1){
            ButtonBoy.onClick.AddListener(TaskOnClickBoy);
        }else
        {
            ButtonBoy.onClick.AddListener(TaskOnClickGirl);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClickBoy(){
        SceneManager.LoadScene("Test");
        //SceneManager.LoadScene("Test", LoadSceneMode.Additive);
		Debug.Log ("You have started the Battle as a boy");
	}
    void TaskOnClickGirl(){
        SceneManager.LoadScene("Test 1");
        //SceneManager.LoadScene("Test", LoadSceneMode.Additive);
		Debug.Log ("You have started the Battle as a Girl");
	}
}
