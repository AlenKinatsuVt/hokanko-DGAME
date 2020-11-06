using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Script211 : MonoBehaviour
{
    /// <summary>OKマークのオブジェクト</summary>
    public GameObject m_OK; // public でメンバ変数を宣言することにより、Inspector から値を設定できる
    public GameObject m_NG;

    public GameObject WhiteCircle;
    public GameObject RedCircle;
    
    GameObject[] tagGameobj;
    int objectCount;
    void Start()
    {
        GameObject WhiteCircle=this.GetComponent<GameObject>();
        tagGameobj = GameObject.FindGameObjectsWithTag("gameobject");
        objectCount = tagGameobj.Length;
        Debug.Log(objectCount);
    }

    void Update()

    {

        Vector3 position2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position2.z = 0;
        m_NG.transform.position = position2;

        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition); // 画面上の座標をシーンの座標に変換する
            Debug.LogFormat("スクリーン座標 {0} をワールド座標 {1} に変換した。", Input.mousePosition.ToString(), position.ToString());
            position.z = 0; // 変換するだけでは Z 座標が不定（カメラの位置）になるので、0 にする
            m_OK.transform.position = position;
            GetComponent<SpriteRenderer>().color = Color.black;
            WhiteCircle=this.GetComponent<SpriteRenderer>().color=Color.black;
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("左クリック");
        }

        if (Input.GetMouseButtonUp(1))
        {
            Debug.Log("右クリック");
        }

    }
   
}
