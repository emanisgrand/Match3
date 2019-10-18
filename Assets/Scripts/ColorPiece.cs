using System.Collections.Generic;
using UnityEngine;

public class ColorPiece : MonoBehaviour
{
    public enum SpoopType
    {
        SKULL1,
        SKULL2,
        BAT,
        PENTAGRAM,
        SPIDER,
        SUMPKIN,
        CRYSTALBALL,
        ANY,
        COUNT
    };

    [System.Serializable]
    public struct SpoopySprites {
        public SpoopType spoop;
        public Sprite sprite;
    };

    public SpoopySprites[] spoopySprites;

    private SpoopType spoop;
    public SpoopType Spoop
    {
        get { return spoop; }
        set { SetSpoop(value); }
    }

    public int NumSpoop {
        get { return spoopySprites.Length; }
    }
    
    private SpriteRenderer sprite;
    private Dictionary<SpoopType, Sprite> spoopySpriteDict;
    void Awake()
    {
        sprite = transform.Find("piece").GetComponent<SpriteRenderer>();
        spoopySpriteDict = new Dictionary<SpoopType, Sprite>();

        for (int i= 0; i < spoopySprites.Length; i++) {
            if (!spoopySpriteDict.ContainsKey(spoopySprites[i].spoop)) {
                spoopySpriteDict.Add(spoopySprites[i].spoop, spoopySprites[i].sprite);
            }
        }
    }

    public void SetSpoop (SpoopType newSpoop) {
        spoop = newSpoop;

        if (spoopySpriteDict.ContainsKey(newSpoop)) {
            sprite.sprite = spoopySpriteDict[newSpoop];
        }
    }
}
