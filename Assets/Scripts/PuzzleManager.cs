using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public UIManager uimanager;

    public PuzzlePieza[] pieces;

    public Andar player = null;

    private bool completed = false;

    public Animator doorAnimator;
    

    private void Start()
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            pieces[i].manager = this;
        }
    }

    public void ActivatePuzzle(Andar _player)
    {
        player = _player;
        this.gameObject.SetActive(true);
        
    }

    public bool IsPuzzleCorrect()
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            if (pieces[i].correct == false)
                return false;
        }

        for (int i = 0; i < pieces.Length; i++)
            pieces[i].completed = true;

        CompletePuzzle();
        return true;
    }

    void CompletePuzzle()
    {
        uimanager.CompletePuzzleText(() =>
        {
            completed = true;
            player.PuzzleCompleted();
            doorAnimator.SetBool("Open", true);
            Destroy(doorAnimator.GetComponent<BoxCollider2D>());
            this.gameObject.SetActive(false);
        });
    }

    public bool IsPuzzleCompleted()
    {
        return completed;
    }
    
}
