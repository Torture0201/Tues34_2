using System;
using TMPro;
using UnityEngine;

public class StopWatchView : MonoBehaviour
{
    // 時間を表示するテキストをアタッチする
    [SerializeField] private TextMeshProUGUI _dateTimeText;
    // Start,Stop を表示するボタンについているテキストをアタッチする
    [SerializeField] private TextMeshProUGUI _buttonText;
    // 時間を管理する変数をDateTimeで生成する（時間は０になる）
    private DateTime _timer = new DateTime();
    // ストップウォッチが動いていれば tru, 止まっていれば false 
    private bool _isStart = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DateTime dt = DateTime.Now;
        Debug.Log(dt);
        // フォーマット付きで表示する
        string result = dt.ToString("yyyy/MM/dd HH:mm:ss");
        Debug.Log(dt);
        Debug.Log(result);
        result = dt.ToString("yyyy年MM月dd日 HH時mm分ss秒");
        Debug.Log(result);
        // 時間を表示する（分：秒：ミリ秒）
        _dateTimeText.text = _timer.ToString("mm:ss:ff");
    }

    // Update is called once per frame
    void Update()
    {
        // ストップウィッチが止まっていれば何もしない
        if (_isStart == false) return;
        // DateTime で使えるように前のフレームからの経過時間を変化する
        TimeSpan deltaTimeSpan = TimeSpan.FromSeconds(Time.deltaTime);
        // 時間を加算する
        _timer = _timer.Add(deltaTimeSpan);
        // 時間を表示する（分：秒：ミリ秒）
        _dateTimeText.text = _timer.ToString("mm:ss:ff");


    }
    public void OnClickButton()
    {
        _isStart = !_isStart;
        if (_isStart) _buttonText.text = "Stop";
        else          _buttonText.text = "Start";
    }
}
