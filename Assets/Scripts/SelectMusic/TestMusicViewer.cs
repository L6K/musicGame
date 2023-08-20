using UnityEngine;
using System.Linq;
using System.IO;
using System.Collections.Generic;

public class TestMusicViewer : MonoBehaviour
{
    [SerializeField] private MusicScrollView musicScrollView;
    void Start()
    {
        string[] filePaths = Directory.GetFiles(@"./Assets/Resources/Musics", "*.wav");
        string[] fileNamesWithoutExtensions = filePaths.Select(path => Path.GetFileNameWithoutExtension(path)).ToArray();
        List<MusicItemData> mid = new List<MusicItemData>();
        for (int i = 0; i < fileNamesWithoutExtensions.Length; i++)
        {
            string mName = fileNamesWithoutExtensions[i];
            mid.Add(new MusicItemData(i, mName));
            
        }
        musicScrollView.UpdateData(mid);
    }
}