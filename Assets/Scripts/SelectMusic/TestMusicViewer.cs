using UnityEngine;
using System.Linq;

public class TestMusicViewer : MonoBehaviour
{
    [SerializeField] private MusicScrollView musicScrollView;
    void Start()
    {
        var items = Enumerable.Range(0, 10).
            Select(i => new MusicItemData(i, $"‰¹Šy{i:D2}")).ToArray();

        musicScrollView.UpdateData(items);
    }
}