using TMPro;
using UnityEngine;

public class Button1View : MonoBehaviour
{
    //　データを外部プログラムから呼ぼ出されずに　inspector に
    //　表示したい場合、privat にして [SeriaalizField] を
    //　先頭につける
    //　文字列を表示するテキストをアタッチする
    [SerializeField] private TextMeshProUGUI _msgText;

    // 配列
    // 同じ型の箱を用意して一列に並べる
    // 先頭から0,1,2...としてデータを取得する
    private string[] _messages = { "Hello World!", "Chanege World" };
    // 配列の選択する番号
    private int _counter = 0;


    /// <summary>
    /// テキストで Hello と表示する
    /// </summary>
    public void HelloMessage()
    {
        _msgText.text = "Hello World";
    }

    /// <summary>
    /// テキストに表示する文字の入れ替え
    /// </summary>

    public void ChangeMessage()
    {
        //　_counter が示す番号の配列データをテキストに表示する
        _msgText.text = _messages[_counter];
        // _counter に1加える方法は３つ
        //_counter = _counter + 1;
        //_counter += 1;
        _counter++;
        if (_counter >= 2) _counter = 0;

    }
}
