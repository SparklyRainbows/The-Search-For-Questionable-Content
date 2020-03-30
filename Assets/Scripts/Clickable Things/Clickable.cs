using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Clickable : MonoBehaviour
{
    public abstract void OnClick();

    private float hoverScale = 1.3f;

    #region Mouse events
    private void OnMouseDown() {
        OnClick();
    }

    private void OnMouseEnter() {
        transform.localScale *= hoverScale;
    }

    private void OnMouseExit() {
        transform.localScale /= hoverScale;
    }
    #endregion
}
