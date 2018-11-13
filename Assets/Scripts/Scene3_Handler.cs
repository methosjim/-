using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3_Handler : MonoBehaviour
{
    public GameObject canvas = null;

    private UIHandler messageBox = null;

    // Use this for initialization
    void Start()
    {
        InitObject();
        CheckObject();
    }
    void InitObject()
    {
        try
        {
            GameObject _prefab = Resources.Load<GameObject>("Prefabs\\MessageBox");

            if (_prefab != null)
            {
                GameObject obj = Instantiate(_prefab);
                if (canvas != null)
                {
                    obj.transform.parent = canvas.transform;                    // B.tf.parent = A.tf  //B在A裡面
                    obj.transform.localPosition = Vector3.zero;
                    messageBox = obj.GetComponent<UIHandler>();
                }
            }
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }

    void CheckObject()
    {
        try
        {
            if (messageBox != null)
            {
                messageBox.SetTitle("我在場景中設定東西!!!!");
            }
            if (messageBox != null)
            {
                messageBox.Setmessage("456");
            }

        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }
}
