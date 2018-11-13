using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartManager : MonoBehaviour {

    public GameObject UIRoot = null;

    private List<GameObject> ModelList = new List<GameObject>();


    void Start()
    {
        //scan UI 
        if (UIRoot != null)
        {
            int childCount = UIRoot.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                GameObject child = UIRoot.transform.GetChild(i).gameObject;
                if (child.name.Equals("Btn_Start"))
                {
                    Button button = child.GetComponent<Button>();
                    button.onClick.AddListener(BtnStartOnClick);
                }

                if (child.name.Equals("Btn_Exit"))
                {
                    (child.GetComponent<Button>())
                        .onClick
                        .AddListener(BtnExitOnClick);
                }
            }
        }
    }
    
    public void BtnStartOnClick()
    {
        Debug.Log("BtnStartOnClick");
        SceneManager.LoadScene("GameScene5", LoadSceneMode.Single);

    }
    public void BtnExitOnClick()
    {
        Debug.Log("BtnExitOnClick");
    }
}
