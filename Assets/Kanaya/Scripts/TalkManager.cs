using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TalkManager : MonoBehaviour
{
    public UIText uitext;
    [SerializeField]
    [Header("分岐A")] GameObject _ButtonA;//【何も言わずそのまま渡す】
    [SerializeField]
    [Header("分岐B")] GameObject _ButtonB;//【思ったことをそのまま言って渡す】
    [SerializeField]
    [Header("スタートボタン")]public GameObject _button;
    void Start()
    {
        _button.SetActive(false);
        StartCoroutine("Cotest");
    }
    IEnumerator Skip()
    {
        while (uitext.playing) yield return 0;
        while (!uitext.IsClicked()) yield return 0;
    }
    IEnumerator Cotest()
    {
        uitext.DrawText("昼休みになり昼食を落ち着いて食べようと珍しく旧校舎に来てみるとマスクをつけた女子が窓際に立っていた。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("自分以外にもいるんだなぁと考えていると急に風が吹きマスク女子のマスクが飛ばされ外れる。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("風に乗って自分の方に飛んでくるのでジャンプしてキャッチする。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("マスクの持ち主はマスクを拾おうと振り返ると自分に気づいて顔を隠してこっちに来る。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("新坂雪枝", "あ、あのそれ私のマスクです...とってくれてありがとうございます");
        yield return StartCoroutine("Skip");

        uitext.DrawText("主人公", "い、いえ飛んできたので");
        yield return StartCoroutine("Skip");
        StartCoroutine("RouteA");//本来はBranchに移行する
    }
    public void Branch()
    {
        _ButtonA.SetActive(true);
        _ButtonB.SetActive(false);
    }
    IEnumerator RouteA()
    {
        uitext.DrawText("主人公", "えっと...どうぞ");
        yield return StartCoroutine("Skip");

        uitext.DrawText("新坂雪枝", "あ、ありがとうございますこれがなかったらどうしようかと");
        yield return StartCoroutine("Skip");

        uitext.DrawText("主人公", "それなら、渡せてよかったです");
        yield return StartCoroutine("Skip");

        uitext.DrawText("お礼の意味を込めてのお辞儀をすると彼女はどこかへ行ってしまった。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("花粉症の季節でもないのになんでマスク付けてるんだろう？");
        yield return StartCoroutine("Skip");

        uitext.DrawText("もしかしたらほこりアレルギーとかそういうのかもしれない。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("そう思いそれ以上は考えず近くの教室でお弁当を食べる。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("主人公","それにしても、むちゃくちゃかわいかったなぁ...");
        yield return StartCoroutine("Skip");

        uitext.DrawText("お礼の意味を込めてのお辞儀をすると彼女はどこかへ行ってしまった。");
        yield return StartCoroutine("Skip");

        _button.SetActive(true);
    }
    IEnumerator RouteB()
    {
        uitext.DrawText("主人公", "かわいいのになんでマスクしてるんですか？");
        yield return StartCoroutine("Skip");

        uitext.DrawText("新坂雪枝", "へっ！？か、かわいくないです！そ、そんなことよりマスク！マスク渡してください！");
        yield return StartCoroutine("Skip");

        uitext.DrawText("しまった。何も考えずに思っていたことが口から滑ってしまった。目の前の人物に言われ慌ててマスクを渡す。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("確実にやばいやつ認定されたな...初対面でいきなりかわいいとかありえないだろ。なんとかして勘違いされないように必死に弁明しようと説明をはじめる。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("主人公", "あの誤解しないで！別に下心があってあんなこと言ったわけじゃなくてほんと！口が勝手に滑っただけなんで！だから...その...");
        yield return StartCoroutine("Skip");

        uitext.DrawText("新坂雪枝","いいんです！別に誤解してないので、それに私かわいくないのでそんなこと言わないでください、マスクありがとうございました");
        yield return StartCoroutine("Skip");

        uitext.DrawText("ぺこりとお辞儀をして走ってどこかへ行ってしまった。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("なんとなく追いかけようかと思ったが追いかけるほどの理由がないため");
        yield return StartCoroutine("Skip");

        uitext.DrawText("追いかけるのはやめ、最初の予定通り近くの教室でお弁当を食べる。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("それにしても、あの人むちゃくちゃかわいかったなぁ...なんでマスク付けてるんだろ");
        yield return StartCoroutine("Skip");

        
    }
}

