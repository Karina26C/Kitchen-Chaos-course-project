using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IhasProgress 
{
    public event EventHandler<OnProgressChangedEventArgs> OnProgressChanged;
    public class OnProgressChangedEventArgs : EventArgs
    {
        public float progressNormalized;
    }
}
