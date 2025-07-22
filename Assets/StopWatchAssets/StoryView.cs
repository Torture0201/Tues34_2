using System.Collections;
using TMPro;
using UnityEngine;

public class StoryView : MonoBehaviour
{
    // �������\������Gs�Ƃ��A�^�b�`����
    [SerializeField] private TextMeshProUGUI _storyText;
    // �\�����镶��
    private string _message = "Feuer! Sperrfeuer! Los!Achtung! Deckung! Hinlegen! Halt!���ցI�O���ցI�����Ď��̕��܂ŁI���̂Ă����̊o��������IFeuer! Sperrfeuer! Los!Achtung! Deckung! Hinlegen! Halt�������邾�낤�@���̖C������R�����v���߂����ݒׂ��I���ݒׂ��I���N�A��X�̔C���͉����r�ł��I��@�c�炸�̟r�ł��ׂ��ׂ����Ƃ͗B��n����n��I���̉��̒��i��ōs���̂��e�ۂ̉J�ɑł���ɍs���̂��Ύ~�疜�I�鍑(����)�ׂ̈��I���ցI�O���ցI�����Ď��̕��܂ŁI���̂Ă��o���������I�������I�]�����I�����đ��̍���S�ĕ�����騂��グ��I���������ɒz���Ă݂���I�V�ɓ͂�����(�Ђ�)�̎R���IFeuer! Sperrfeuer! Los!Achtung! Deckung! Hinlegen! Halt!�ǂ��ɋ��|������ƌ����񂾌��� �������ԉ΂̗l���T���U�炷�@�T���U�炷��̏��Ձ@�Y�ꂿ�Ⴂ�Ȃ������̔M���@��ꂽ���D���Ō�̙���@�����������j�āA���ꂱ�������߂�̂��I���J�������������Ęa���Ȃ�ĉ���̂Ă��������̏��Ɛ�]�Ɠ������|�������C�̍����͒n�������@�y���̗l�����̎l���͗x��ׂɗx�苶���חL��̂��I�l�Ԃɉ��l�Ȃǖ������l�����ғ��m�̑����ɖ��̓k�Ԃ��炩���Ă݂���I�@���������ł��@�������z���n���Ă�܂��ɏΌ�(�t�@���X)�@�s�𗝂����̋N���]�����ցI�O���ցI�����Ď��̕��܂ŁI���̂Ă��o���������I�������I�]�����I�����đ��̍���S�ĕ�����騂��グ��I���������ɒz���Ă݂���I�V�ɓ͂�����(�Ђ�)�̎R�ɖؗ삷�鑞���݂����~������������Feuer! Sperrfeuer! Los!Achtung! Deckung! Hinlegen! Halt!";
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
        // �񓯊��̃R���[�`�����Ăяo��
        StartCoroutine(StoryAction());
    }

    private IEnumerator StoryAction()
    {
        var index = 0;
        while(index < _message.Length)
        {
            // �J�E���^�[���P�i�߂�
            index++;
            // �擪���� index ���������؂�o��
            var msg = _message.Substring(0, index);
            // �e�L�X�g�ɕ\������
            _storyText.text = msg;
            // 0.1 �b���ԑ҂�
            yield return new WaitForSeconds(0.1f);
        }

    }

}
