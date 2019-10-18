using System.Collections;
using UnityEngine;

public class ClearColorPiece : ClearablePiece {

    private ColorPiece.SpoopType spoop;
    public ColorPiece.SpoopType Spoop {
        get { return spoop;}
        set { spoop = value; }
    }
    public override void Clear() {
        base.Clear();
        piece.GridRef.ClearColor(spoop);
    }
}