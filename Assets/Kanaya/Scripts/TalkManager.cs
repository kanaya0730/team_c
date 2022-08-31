using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TalkManager : MonoBehaviour
{
    [SerializeField]
    UIText uitext;

    /// <summary>【何も言わずそのまま渡す】</summary>
    [SerializeField]
    [Header("分岐A")] 
    GameObject _ButtonA;

    /// <summary>【思ったことをそのまま言って渡す】</summary>
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

    [SerializeField]
    [Header("主人公立ち絵")] 
    GameObject _playerImage;

    [SerializeField]
    [Header("スタートボタン")]
    GameObject _button;

    void Start()
    {
        StartCoroutine(Cotest());
    }
    IEnumerator Skip()
    {
        while (uitext._playing) yield return 0;
        while (!uitext.IsClicked()) yield return 0;
    }
    IEnumerator Cotest()
    {
        _playerImage.SetActive(true);
        uitext.DrawText("昼休みになり昼食を落ち着いて食べようと珍しく旧校舎に来てみるとマスクをつけた女子が窓際に立っていた。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("自分以外にもいるんだなぁと考えていると急に風が吹きマスク女子のマスクが飛ばされ外れる。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("風に乗って自分の方に飛んでくるのでジャンプしてキャッチする。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("マスクの持ち主はマスクを拾おうと振り返ると自分に気づいて顔を隠してこっちに来る。");
        yield return StartCoroutine("Skip");

        _heroineImage[0].SetActive(true);
        uitext.DrawText("新坂雪枝(にいさかゆきえ)", "あ、あのそれ私のマスクです...とってくれてありがとうございます");
        yield return StartCoroutine("Skip");

        uitext.DrawText("主人公", "い、いえ飛んできたので");
        yield return StartCoroutine("Skip");
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
    public void BranchA1()
    {
        StartCoroutine(RouteA1());
    }
    public void BranchB1()
    {
        StartCoroutine(RouteB1());
    }
    IEnumerator RouteA()
    {
        _ButtonA.SetActive(false);
        _ButtonB.SetActive(false);
        uitext.DrawText("主人公", "えっと...どうぞ");
        yield return StartCoroutine(Skip());

        uitext.DrawText("雪枝", "あ、ありがとうございますこれがなかったらどうしようかと");
        yield return StartCoroutine(Skip());

        uitext.DrawText("主人公", "それなら、渡せてよかったです");
        yield return StartCoroutine(Skip());

        uitext.DrawText("お礼の意味を込めてのお辞儀をすると彼女はどこかへ行ってしまった。");
        yield return StartCoroutine(Skip());

        uitext.DrawText("花粉症の季節でもないのになんでマスク付けてるんだろう？");
        yield return StartCoroutine("Skip");

        uitext.DrawText("もしかしたらほこりアレルギーとかそういうのかもしれない。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("そう思いそれ以上は考えず近くの教室でお弁当を食べる。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("主人公","それにしても、むちゃくちゃかわいかったなぁ...");
        yield return StartCoroutine("Skip");

        StartCoroutine("Route");
    }
    IEnumerator RouteB()
    {
        _ButtonA.SetActive(false);
        _ButtonB.SetActive(false);

        uitext.DrawText("主人公", "かわいいのになんでマスクしてるんですか？");
        yield return StartCoroutine("Skip");

        uitext.DrawText("雪枝", "へっ！？か、かわいくないです！そ、そんなことよりマスク！マスク渡してください！");
        yield return StartCoroutine("Skip");

        uitext.DrawText("しまった。何も考えずに思っていたことが口から滑ってしまった。目の前の人物に言われ慌ててマスクを渡す。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("確実にやばいやつ認定されたな...初対面でいきなりかわいいとかありえないだろ。なんとかして勘違いされないように必死に弁明しようと説明をはじめる。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("主人公", "あの誤解しないで！別に下心があってあんなこと言ったわけじゃなくてほんと！口が勝手に滑っただけなんで！だから...その...");
        yield return StartCoroutine("Skip");

        uitext.DrawText("雪枝","いいんです！別に誤解してないので、それに私かわいくないのでそんなこと言わないでください、マスクありがとうございました");
        yield return StartCoroutine("Skip");

        uitext.DrawText("ぺこりとお辞儀をして走ってどこかへ行ってしまった。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("なんとなく追いかけようかと思ったが追いかけるほどの理由がないため");
        yield return StartCoroutine("Skip");

        uitext.DrawText("追いかけるのはやめ、最初の予定通り近くの教室でお弁当を食べる。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("それにしても、あの人むちゃくちゃかわいかったなぁ...なんでマスク付けてるんだろ");
        yield return StartCoroutine("Skip");

        uitext.DrawText("そんなことを考えながらお弁当を食べ始める。");
        yield return StartCoroutine("Skip");

        StartCoroutine("Route");
    }
    IEnumerator Route()
    {
        uitext.DrawText("翌日…");
        yield return StartCoroutine("Skip");

        uitext.DrawText("担任に用事があり一学年上、三年生の階まで探しに来てみると数日前に旧校舎で出会ったマスクの人がいた。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("先輩だったんだ知らなかった...って僕タメ口使っちゃったじゃん！謝んないと！");
        yield return StartCoroutine("Skip");

        uitext.DrawText("先輩にタメ口を使ってしまったことを謝ろうと注意されない程度に走り、近づいて声をかける。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("主人公", "あ、あの！この間はすみませんでした！");
        yield return StartCoroutine("Skip");

        uitext.DrawText("雪枝", "この間って、マスクとってくれた人ですよね、急に謝ってきてどうしたんですか？");
        yield return StartCoroutine("Skip");

        uitext.DrawText("主人公", "いや、その、先輩だって知らずタメ口使ったので謝ろうと");
        yield return StartCoroutine("Skip");

        uitext.DrawText("雪枝", "あぁそういうことなんですね謝らなくてもよかったのに");
        yield return StartCoroutine("Skip");

        uitext.DrawText("そんな風に話していると急にほかの女子生徒からからかってくるような言葉が飛んでくる。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("厳密には僕ではなく目の前にいる先輩に対してだ。しかも悪意を持ってだ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("なにを言ってるんだあの人たちは、何か言わないと気が済まない。");
        yield return StartCoroutine("Skip");

        StartCoroutine("Branch1");
        _button.SetActive(true);
    }
    IEnumerator RouteA1()
    {
        _ButtonA1.SetActive(false);
        _ButtonB1.SetActive(false);
        uitext.DrawText("主人公","あの！さっきからなんですか！そんなこと言って楽しいですか!");
        uitext.DrawText("楽しいっていうか事実だからしょうがないじゃん");
        yield return StartCoroutine("Skip");
        StartCoroutine(Route1());
    }
    IEnumerator RouteB1()
    {
        _ButtonA1.SetActive(false);
        _ButtonB1.SetActive(false);
        yield return StartCoroutine(Route1());
    }
    IEnumerator Route1()
    {
        uitext.DrawText("プレイしていただきありがとうございました。");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("TitleScene");
        yield return StartCoroutine("Skip");
    }
}

