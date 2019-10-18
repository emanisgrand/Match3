﻿using UnityEngine;

public class GamePiece : MonoBehaviour {
    public int score;
    
    private int x;
    private int y;

    public int X {
        get { return x; }
        set {
            if (IsMovable()) {
                x = value;
            }
        }
    }

    public int Y {
        get { return y; }
        set {
            if (IsMovable()) {
                y = value;
            }
        }
    }

    private Grid.PieceType type;

    public Grid.PieceType Type {
        get { return type; }
    }

    private Grid grid;

    public Grid GridRef {
        get { return grid; }
    }

    private MovablePiece movableComponent;
    public MovablePiece MovableComponent {
        get { return movableComponent; }
    }

    private ColorPiece colorComponent;
    public ColorPiece ColorComponent {
        get { return colorComponent; }
    }

    private ClearablePiece clearableComponent;
    public ClearablePiece ClearableComponent {
        get { return clearableComponent; }
    }

    private AnimatedPiece animatedComponent;
    public AnimatedPiece AnimatedComponent {
        get { return animatedComponent; }
    }
    private void Awake() {
        movableComponent = GetComponent<MovablePiece>();
        colorComponent = GetComponent<ColorPiece>();
        clearableComponent = GetComponent<ClearablePiece>();
        animatedComponent = GetComponent<AnimatedPiece>();
    }

    public void Init(int _x, int _y, Grid _grid, Grid.PieceType _type) {
        x = _x;
        y = _y;
        grid = _grid;
        type = _type;
    }

    private void OnMouseEnter() {
        grid.EnterPiece(this);
    }

    private void OnMouseDown() {
        grid.PressedPiece(this);
    }

    private void OnMouseUp() {
        grid.ReleasePiece();
    }

    public bool IsMovable() {
        return movableComponent != null;
    }

    public bool IsSpoopy() {
        return colorComponent != null;
    }

    public bool IsClearable() {
        return clearableComponent != null;
    }

    public bool IsAnimated() {
        return animatedComponent != null;
    }
}