using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Kanya : MonoBehaviour
{
    TextAsset csvFile; // CSVファイル
    List<string[]> csv = new List<string[]>(); // CSVの中身を入れるリスト

    int i = 0;
    int a = 0;

    [SerializeField] 
    [Header("マップデータ")]GameObject[][] date;
    void Start()
    {
        csvFile = Resources.Load("MapDate") as TextAsset; // Resouces下のCSVの読み込み
        StringReader reader = new StringReader(csvFile.text);

        while (reader.Peek() != -1 && i < 21 && a < 4)
        {
            //Debug.Log(reader.ReadLine());
            string line = reader.ReadLine();
            csv.Add(line.Split(','));
            //Debug.Log(csv[i][a]);
        }
        for (int i = 0; i < 7; i++)
        {
            for (int a = 0; a < 8; a++)
            {
                switch (csv[i][a])
                {
                    case "1":
                        Debug.Log("地面");
                        /*GameObject obj = (GameObject)Resources.Load("Ground");
                        Instantiate(obj, new Vector3(i, 0f, 0.0f), Quaternion.identity);*/
                        break;
                    case "0":
                        Debug.Log("空");
                        /*GameObject obj1 = (GameObject)Resources.Load("Sky");
                        Instantiate(obj1, new Vector3(i, 0f, 0.0f), Quaternion.identity);*/
                        break;
                    case "2":
                        Debug.Log("壁");
                        /*GameObject obj2 = (GameObject)Resources.Load("Wall");
                        Instantiate(obj2, new Vector3(i, 0f, 0.0f), Quaternion.identity);*/
                        break;
                    case "3":
                        Debug.Log("浮く床");
                        /*GameObject obj3 = (GameObject)Resources.Load("Ground2");
                        Instantiate(obj3, new Vector3(i, 0f, 0.0f), Quaternion.identity);*/
                        break;
                    case "4":
                        Debug.Log("動く壁");
                        /*GameObject obj4 = (GameObject)Resources.Load("Wall2");
                        Instantiate(obj4, new Vector3(i, 0f, 0.0f), Quaternion.identity);*/
                        break;
                    case "5":
                        Debug.Log("ゴール");
                        /*GameObject obj5 = (GameObject)Resources.Load("Gaol");
                        Instantiate(obj5, new Vector3(i, 0f, 0.0f), Quaternion.identity);*/
                        break;
                    default:
                        Debug.Log("エラー");
                        break;
                }
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
