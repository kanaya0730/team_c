using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoder : MonoBehaviour
{
    [SerializeField]
    [Header("ロードしたいシーンの名前")] string _loadSceneName;
    public void OnClick()
    {
        SceneManager.LoadScene(_loadSceneName);
    }
}