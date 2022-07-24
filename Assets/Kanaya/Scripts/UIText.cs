using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIText : MonoBehaviour
{
    /// <summary>喋っている人の名前</summary>
    [SerializeField]
    [Header("喋っている人の名前")]
    Text nameText;
    /// <summary>喋っている内容やナレーション</summary>
    [SerializeField]
    [Header("喋っている内容やナレーション")]
    Text talkText;
    /// <summary>テキストエフェクト</summary>
    [SerializeField]
    [Header("テキストエフェクト")]
    GameObject triangle;

    public bool playing = false;
    public float textSpeed = 0.1f;

    void Update()
    {
        if(playing == false)
        {
            triangle.SetActive(true);
        }
        else
        {
            triangle.SetActive(false);
        }
    }
    /// <summary>クリックで次のページを表示させる</summary>
    public bool IsClicked()
    {
        if (Input.GetMouseButtonDown(0)) return true;
        return false;
    }
    // ナレーション用のテキストを生成する
    public void DrawText(string text)
    {
        nameText.text = "";
        StartCoroutine("CoDrawText", text);
    }
    // 通常会話用のテキストを生成する
    public void DrawText(string name, string text)
    {
        nameText.text = name;
        StartCoroutine("CoDrawText","「" + text + "」");
    }
    // テキストがヌルヌル出てくるためのコルーチン
    IEnumerator CoDrawText(string text)
    {
        playing = true;
        float time = 0;
        while (true)
        {
            yield return 0;
            time += Time.deltaTime;

            // クリックされると一気に表示
            if (IsClicked()) break;

            int len = Mathf.FloorToInt(time / textSpeed);
            if (len > text.Length) break;
            talkText.text = text.Substring(0, len);
        }
        talkText.text = text;
        yield return 0;
        playing = false;
    }
}
