using System;

public class Player
{
    public delegate void SayWordHandler();
    public event SayWordHandler SayWord;

    public Player()
    {

    }
}
