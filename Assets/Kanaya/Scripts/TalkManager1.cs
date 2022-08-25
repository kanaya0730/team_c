using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TalkManager1 : MonoBehaviour
{
    [SerializeField]
    UIText uitext;

    /// <summary>【見る】</summary>
    [SerializeField]
    [Header("分岐A")] 
    GameObject _ButtonA;

    /// <summary>【見ない】</summary>
    [SerializeField]
    [Header("分岐B")]
    GameObject _ButtonB;

    /// <summary>【何か反論する】</summary>
    [SerializeField]
    [Header("分岐A1")] 
    GameObject _ButtonA1;

    /// <summary>【何も反論しない】</summary>
    [SerializeField]
    [Header("分岐B1")] 
    GameObject _ButtonB1;

    /// <summary>[0],踊り場 [1],昇降口 [2],校門 [3],校舎裏 [4],教室 [5],廊下</summary>
    [SerializeField]
    [Header("背景")]
    GameObject[] _backGround;

    /// <summary>[0],通常 [1],笑顔 [2],照れる [3],困る [4],落ち込む</summary>
    [SerializeField]
    [Header("ヒロイン1立ち絵")] 
    GameObject[] _heroineImage;

    /// <summary>主人公立ち絵</summary>
    [SerializeField]
    [Header("主人公立ち絵")] 
    GameObject _playerImage;

    [SerializeField]
    [Header("スタートボタン")]
    GameObject _button;
    
    public void Start()
    {
        StartCoroutine(Cotest1());
    }
    IEnumerator Skip()
    {
        while (uitext._playing) yield return 0;
        while (!uitext.IsClicked()) yield return 0;
    }
    IEnumerator Cotest1()
    {
        _heroineImage[0].SetActive(true);
        _playerImage.SetActive(true);
        uitext.DrawText("下校をするために下駄箱に行くとそこにはこの学園で有名な人気者、道浦洸がいた。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("隣のクラスのため話したこともないが一応会釈をするが無視される。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("少しだけ傷つきながら靴を取り出してると足元に二つ折りにされた紙が落ちてきた。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("中を見ますか？");
        StartCoroutine("Branch");
    }
    public void Branch()
    {
        _ButtonA.SetActive(true);
        _ButtonB.SetActive(true);
    }
    public void Branch1()
    {
        _ButtonA1.SetActive(true);
        _ButtonB1.SetActive(true);
    }
    public void BranchA()
    {
        StartCoroutine(RouteA());
    }
    public void BranchB()
    {
        StartCoroutine(RouteB());
    }
    IEnumerator RouteA()
    {
        _ButtonA.SetActive(false);
        _ButtonB.SetActive(false);
        uitext.DrawText("さすがに人のを勝手に見る趣味はないが少し気になる。少しだけ見ようか悩んでいると突然持っていた紙を奪われる。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("道浦 洸（みちうら ひかる）", "ちょっと勝手に人の取らないでよ！もしかしてだけどこの中身見てないよね？");
        yield return StartCoroutine("Skip");

        uitext.DrawText("洸", "見てないって言って！");
        yield return StartCoroutine("Skip");

        _heroineImage[0].SetActive(false);

        uitext.DrawText("主人公","見てないよ！さすがに人のを勝手には見ないよ");
        yield return StartCoroutine("Skip");

        uitext.DrawText("洸", "ほんとうにー？まぁいいや嘘つけなさそうな顔してるし、なるべくはやくこのこと忘れてよね");
        yield return StartCoroutine("Skip");

        uitext.DrawText("そう彼女は僕に告げると靴を履いてさっさと帰って行ってしまった。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("結局あの紙の中身が何なのかはわからず少し気になるが考えても仕方ない、今日はもう帰ろう。");
        yield return StartCoroutine("Skip");
        StartCoroutine("Route");
    }
    IEnumerator RouteB()
    {
        _ButtonA.SetActive(false);
        _ButtonB.SetActive(false);

        uitext.DrawText("紙を開くと中には中々に気持ち悪い文が書かれていた。その気持ち悪さに引いていると突然持っていた紙を奪われる。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("洸", "ちょっと勝手に人の取らないでよ！もしかしてだけどこの中身見てないよね？見てないって言って！");
        yield return StartCoroutine("Skip");

        uitext.DrawText("主人公","みみみみ見てない！気持ち悪い文なんて見てないよ！");
        yield return StartCoroutine("Skip");

        uitext.DrawText("洸", "嘘つけ！見たんじゃん！！何が“見てない！”、なの？このこと誰かに言ったら容赦しないから!!");
        yield return StartCoroutine("Skip");

        uitext.DrawText("怒りながらそう言うと、少し乱暴に靴を履いて帰ってしまった。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("彼女に悪いことしたなと思いながら、もしうっかり喋ったりでもしたらなにをされるか想像するとイヤな想像ができ、身震いする");
        yield return StartCoroutine("Skip");

        _heroineImage[0].SetActive(false);

        uitext.DrawText("うっかり喋ったりでもしたらたまったもんじゃない、喋らないようにしないと。そのことを肝に銘じながら自分も帰る。");
        yield return StartCoroutine("Skip");
        _button.SetActive(true);
    }
    IEnumerator Route()
    {
        uitext.DrawText("プレイしていただきありがとうございました。");
        yield return StartCoroutine("Skip");
    }
}

