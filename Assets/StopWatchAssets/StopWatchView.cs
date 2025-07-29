using System;
using TMPro;
using UnityEngine;

public class StopWatchView : MonoBehaviour
{
    // ���Ԃ�\������e�L�X�g���A�^�b�`����
    [SerializeField] private TextMeshProUGUI _dateTimeText;
    // Start,Stop ��\������{�^���ɂ��Ă���e�L�X�g���A�^�b�`����
    [SerializeField] private TextMeshProUGUI _buttonText;
    // ���Ԃ��Ǘ�����ϐ���DateTime�Ő�������i���Ԃ͂O�ɂȂ�j
    private DateTime _timer = new DateTime();
    // �X�g�b�v�E�H�b�`�������Ă���� tru, �~�܂��Ă���� false 
    private bool _isStart = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DateTime dt = DateTime.Now;
        Debug.Log(dt);
        // �t�H�[�}�b�g�t���ŕ\������
        string result = dt.ToString("yyyy/MM/dd HH:mm:ss");
        Debug.Log(dt);
        Debug.Log(result);
        result = dt.ToString("yyyy�NMM��dd�� HH��mm��ss�b");
        Debug.Log(result);
        // ���Ԃ�\������i���F�b�F�~���b�j
        _dateTimeText.text = _timer.ToString("mm:ss:ff");
    }

    // Update is called once per frame
    void Update()
    {
        // �X�g�b�v�E�B�b�`���~�܂��Ă���Ή������Ȃ�
        if (_isStart == false) return;
        // DateTime �Ŏg����悤�ɑO�̃t���[������̌o�ߎ��Ԃ�ω�����
        TimeSpan deltaTimeSpan = TimeSpan.FromSeconds(Time.deltaTime);
        // ���Ԃ����Z����
        _timer = _timer.Add(deltaTimeSpan);
        // ���Ԃ�\������i���F�b�F�~���b�j
        _dateTimeText.text = _timer.ToString("mm:ss:ff");


    }
    public void OnClickButton()
    {
        _isStart = !_isStart;
        if (_isStart) _buttonText.text = "Stop";
        else          _buttonText.text = "Start";
    }
}
