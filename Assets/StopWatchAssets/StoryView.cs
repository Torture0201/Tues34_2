using System.Collections;
using TMPro;
using UnityEngine;

public class StoryView : MonoBehaviour
{
    // 文字列を表示する敵sとをアタッチする
    [SerializeField] private TextMeshProUGUI _storyText;
    // 表示する文章
    private string _message = "Feuer! Sperrfeuer! Los!Achtung! Deckung! Hinlegen! Halt!戦場へ！前線へ！そして死の淵まで！命捨てたその覚悟を示せ！Feuer! Sperrfeuer! Los!Achtung! Deckung! Hinlegen! Halt聴こえるだろう　あの砲声が抵抗する蛆の聲だ踏み潰せ！踏み潰せ！諸君、我々の任務は何だ殲滅だ！一機残らずの殲滅だ為すべきことは唯一つ地獄を創れ！何故炎の中進んで行くのか弾丸の雨に打たれに行くのか笑止千万！帝国(くに)の為だ！戦場へ！前線へ！そして死の淵まで！命捨てた覚悟を示せよ！忠誠を！従順を！そして其の魂を全て捧げ勝鬨を上げよ！さあ此処に築いてみせろ！天に届く死体(ひと)の山を！Feuer! Sperrfeuer! Los!Achtung! Deckung! Hinlegen! Halt!どこに恐怖があると言うんだ見ろ 血肉が花火の様だ撒き散らす　撒き散らす千の傷跡　忘れちゃいないさ炎の熱も　零れた臓腑も最後の呻きも　濁った瞳も嗚呼、それこそを求めるのだ！安寧も平穏も増して和解なんて牙を捨てた飼い犬の所業絶望と動乱を掛けた狂気の沙汰は地獄よりも　楽園の様だその四肢は踊る為に踊り狂う為有るのだ！人間に価値など無い価値無き者同士の争いに命の徒花を咲かせてみせろ！法律も秩序でも　狂った奴が創ってるまさに笑劇(ファルス)　不条理だけの起承転結戦場へ！前線へ！そして死の淵まで！命捨てた覚悟を示せよ！忠誠を！従順を！そして其の魂を全て捧げ勝鬨を上げよ！さあ此処に築いてみせろ！天に届く死体(ひと)の山に木霊する憎しみさえ掻き消す爆発音Feuer! Sperrfeuer! Los!Achtung! Deckung! Hinlegen! Halt!";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartMessage()
    {
        // 非同期のコルーチンを呼び出す
        StartCoroutine(StoryAction());
    }

    private IEnumerator StoryAction()
    {
        var index = 0;
        while(index < _message.Length)
        {
            // カウンターを１進める
            index++;
            // 先頭から index 文字数分切り出す
            var msg = _message.Substring(0, index);
            // テキストに表示する
            _storyText.text = msg;
            // 0.1 秒時間待ち
            yield return new WaitForSeconds(0.1f);
        }

    }

}
