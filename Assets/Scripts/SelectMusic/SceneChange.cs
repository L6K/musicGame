using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneChange : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Text text; 

    // �V�[���J�ڎ��ɕێ������������i�[���邽�߂̐ÓI�ϐ�
    public static string musicName;
    void Start()
    {

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        // �摜���N���b�N�����Ƃ��̓���
        HandleImageClick();
    }

    private void HandleImageClick()
    {
        // �摜�Ɋ֘A�t����ꂽ�e�L�X�g��ÓI�ϐ��ɃZ�b�g
        musicName = text.text;

        // �V�[���J��
        SceneManager.LoadScene("Main");
    }
}