using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField]
    [Header("制限時間")]
    float _limitTime;

    [SerializeField]
    [Header("制限時間テキスト")]
    Text _limitTimeText;
}
