using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FancyScrollView;

class MusicItemData
{
    public int musicId;
    public string musicName;

    public MusicItemData(int id, string musicName)
    {
        musicId = id;
        this.musicName = musicName;
    }
}

class MusicScrollView : FancyScrollView<MusicItemData>
{
    [SerializeField] private Scroller _scroller = default;
    [SerializeField] private GameObject _cellPrefab;
    protected override GameObject CellPrefab => _cellPrefab;

    protected override void Initialize()
    {
        _scroller.OnValueChanged(UpdatePosition);
    }

    public void UpdateData(IList<MusicItemData> items)
    {
        UpdateContents(items);
        _scroller.SetTotalCount(items.Count);
    }
}
