using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneChange : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Text text; 

    // シーン遷移時に保持したい情報を格納するための静的変数
    public static string musicName;
    void Start()
    {

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        // 画像をクリックしたときの動作
        HandleImageClick();
    }

    private void HandleImageClick()
    {
        // 画像に関連付けられたテキストを静的変数にセット
        musicName = text.text;

        // シーン遷移
        SceneManager.LoadScene("Main");
    }
}