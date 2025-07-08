using TMPro;
using UnityEngine;

public class Button1View : MonoBehaviour
{
    //�@�f�[�^���O���v���O��������Ăڏo���ꂸ�Ɂ@inspector ��
    //�@�\���������ꍇ�Aprivat �ɂ��� [SeriaalizField] ��
    //�@�擪�ɂ���
    //�@�������\������e�L�X�g���A�^�b�`����
    [SerializeField] private TextMeshProUGUI _msgText;

    // �z��
    // �����^�̔���p�ӂ��Ĉ��ɕ��ׂ�
    // �擪����0,1,2...�Ƃ��ăf�[�^���擾����
    private string[] _messages = { "Hello World!", "Chanege World" };
    // �z��̑I������ԍ�
    private int _counter = 0;


    /// <summary>
    /// �e�L�X�g�� Hello �ƕ\������
    /// </summary>
    public void HelloMessage()
    {
        _msgText.text = "Hello World";
    }

    /// <summary>
    /// �e�L�X�g�ɕ\�����镶���̓���ւ�
    /// </summary>

    public void ChangeMessage()
    {
        //�@_counter �������ԍ��̔z��f�[�^���e�L�X�g�ɕ\������
        _msgText.text = _messages[_counter];
        // _counter ��1��������@�͂R��
        //_counter = _counter + 1;
        //_counter += 1;
        _counter++;
        if (_counter >= 2) _counter = 0;

    }
}
