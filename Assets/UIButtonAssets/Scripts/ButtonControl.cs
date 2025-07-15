using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    // �{�^���̔ԍ��p�e�L�X�g
    [SerializeField] private TextMeshProUGUI _indexText;
    // �{�^���� iindex
    private int _index;

    /// <summary>
    /// �{�^���� index�@��ݒ肷��֐�
    /// </summary>
    /// <param name="index">�ݒ肷�� index</param>
    public void IndexSetup(int index)
    {
        _index = index;
        DispIndex();
    }
    
    /// <summary>
    /// �e�L�X�g�� index ��\��
    /// </summary>
    private void DispIndex()
    {
        // �����𕶎��ɕϊ����ăe�L�X�g�ɕ\��
        _indexText.text = _index.ToString();
    }
    /// <summary>
    /// �{�^�����������Ƃ��ɌĂяo�����I���W�i���֐�
    /// </summary>
    public void OnClickButton()
    {
        // �V���������̃N���[���i�R�s�[�j�𐶐�����
        // �������Ԃ牺�����Ă���e���̎艺�ɂ���
        var buttonItem = Instantiate(gameObject, transform.parent);
        // �q�G�����L�[�̃{�^���\������ Button �ɕύX
        buttonItem.name = "Button";
        // inddex ���P���Z���ĐV���{�^���ɓn��
        buttonItem.GetComponent<ButtonControl>().IndexSetup(_index + 1);
        // �\���ꏊ�������_���ɐݒ肷��
        buttonItem.transform.localPosition = new Vector3(Random.Range(-920, 920), 
                                                         Random.Range(-500, 500), 
                                                         0);
        // �������폜����
        Destroy(gameObject);
    }
}
