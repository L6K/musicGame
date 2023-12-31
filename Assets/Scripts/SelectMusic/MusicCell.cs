using FancyScrollView;
using UnityEngine;
using UnityEngine.UI;

class MusicCell : FancyCell<MusicItemData>
{
    [SerializeField] Animator animator = default;
    static class AnimatorHash
    {
        public static readonly int Scroll = Animator.StringToHash("scroll");
    }
    float currentPosition = 0;

    public Text _txtName;
    public override void UpdateContent(MusicItemData itemData)
    {
        _txtName.text = itemData.musicName;
    }

    public override void UpdatePosition(float position)
    {
        currentPosition = position;
        if (animator.isActiveAndEnabled)
        {
            animator.Play(AnimatorHash.Scroll, -1, position);
        }
        animator.speed = 0;
    }
    void OnEnable() => UpdatePosition(currentPosition);
}