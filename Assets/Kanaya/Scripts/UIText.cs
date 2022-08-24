using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIText : MonoBehaviour
{
    /// <summary>喋っている人の名前</summary>
    [SerializeField]
    [Header("喋っている人の名前")]
    Text _nameText;
    /// <summary>喋っている内容やナレーション</summary>
    [SerializeField]
    [Header("喋っている内容やナレーション")]
    Text _talkText;
    /// <summary>テキストエフェクト</summary>
    [SerializeField]
    [Header("テキストエフェクト")]
    GameObject _triangle;

    public bool _playing = false;
    public float _textSpeed = 0.1f;

    void Update()
    {
        if(_playing == false)
        {
            _triangle.SetActive(true);
        }
        else
        {
            _triangle.SetActive(false);
        }
    }
    /// <summary>クリックで次のページを表示させる</summary>
    public bool IsClicked()
    {
        if (Input.GetMouseButtonDown(0)) return true;
        return false;
    }
 
    /// <summary>ナレーション用のテキストを生成する</summary>
    public void DrawText(string text)
    {
        _nameText.text = "";
        StartCoroutine(CoDrawText(text));
    }

    /// <summary>通常会話用のテキストを生成する</summary>
    public void DrawText(string name, string text)
    {
        _nameText.text = name;
        StartCoroutine(CoDrawText("「" + text + "」"));
    }

    /// <summary>テキストがヌルヌル出てくるためのコルーチン</summary>
    IEnumerator CoDrawText(string text)
    {
        _playing = true;
        float time = 0;
        while (true)
        {
            yield return null;
            time += Time.deltaTime;

            // クリックされると一気に表示
            if (IsClicked()) break;

            int len = Mathf.FloorToInt(time / _textSpeed);
            if (len > text.Length) break;
            _talkText.text = text.Substring(0, len);
        }
        _talkText.text = text;
        yield return null;
        _playing = false;
    }
}
