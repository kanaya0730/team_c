using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;

public class CSVReader : MonoBehaviour
{
    /// <summary>シナリオデータ</summary>
    TextAsset _textFail;

    public UIText uitext;

    [SerializeField]
    [Header("ファイルの名前")] string _fileName;
    List<string[]> _csvData = new List<string[]>();

    int i = 1;
    void Start()
    {
        _textFail = Resources.Load(_fileName) as TextAsset; // Resouces下のCSVの読み込み
        StringReader reader = new StringReader(_textFail.text);

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            _csvData.Add(line.Split(','));
        }
        StartCoroutine("Cotext");
    }
    IEnumerator Skip()
    {
        while (uitext._playing) yield return null;
        while (!uitext.IsClicked()) yield return null;
    }
    IEnumerator Cotext()
    {
        uitext.DrawText(_csvData[i][0], _csvData[i][1]);//名前,セリフ
        yield return StartCoroutine(Skip());
        i++;
        yield return StartCoroutine(Cotext());
    }
}