﻿// Decompiled with JetBrains decompiler
// Type: SimHaptics.Settings
// MVID: E01F66FE-3F59-44B4-8EBC-5ABAA8CD8267

using System.Collections.Generic;
using System.ComponentModel;

namespace sierses.SimHap
{
  public class Settings : INotifyPropertyChanged
  {
    public Spec Vehicle;
    public Dictionary<string, double> EngineMult;
    public Dictionary<string, double> RumbleMult;
    public Dictionary<string, double> SuspensionMult;
    public Dictionary<string, double> SuspensionGamma;
    public Dictionary<string, double> SlipXMult;
    public Dictionary<string, double> SlipYMult;
    public Dictionary<string, double> SlipXGamma;
    public Dictionary<string, double> SlipYGamma;
    public Dictionary<string, double> Motion;
    private bool unlocked = true;
    private int absPulseLength;
    private int downshiftDurationMs;
    private int upshiftDurationMs;

    public bool Unlocked
    {
      get => this.unlocked;
      set
      {
        this.unlocked = value;
        this.OnPropertyChanged("unlocked");
      }
    }

    public int ABSPulseLength
    {
      get => this.absPulseLength;
      set
      {
        this.absPulseLength = value;
        this.OnPropertyChanged("absPulseLength");
      }
    }

    public int DownshiftDurationMs
    {
      get => this.downshiftDurationMs;
      set
      {
        this.downshiftDurationMs = value;
        this.OnPropertyChanged("downshiftDurationMs");
      }
    }

    public int UpshiftDurationMs
    {
      get => this.upshiftDurationMs;
      set
      {
        this.upshiftDurationMs = value;
        this.OnPropertyChanged("upshiftDurationMs");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if (propertyChanged == null)
        return;
      propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
