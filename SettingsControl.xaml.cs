﻿// Decompiled with JetBrains decompiler
// Type: sierses.Haptics.SettingsControl
// MVID: E01F66FE-3F59-44B4-8EBC-5ABAA8CD8267

using System.Windows;
using System.Windows.Controls;

namespace sierses.Sim
{
	public partial class SettingsControl : UserControl //, IComponentConnector
	{
		public Haptics Plugin { get; }
		// this.InitializeComponent() gets generated by vs from SettingsControl.xaml
		public SettingsControl() => InitializeComponent();

		public SettingsControl(Haptics plugin) : this()
		{
			Plugin = plugin;
			DataContext = Plugin;
			Version.Text = Plugin.PluginVersion;
		}

		private void Refresh_Click(object sender, RoutedEventArgs e)
		{
			Plugin.S.Id = "";
			Haptics.LoadFailCount = 0;
			Haptics.FetchStatus = APIStatus.Retry;
			Haptics.LoadStatus = DataStatus.None;
			Haptics.LoadFinish = !Haptics.LoadFinish;
		}

		private void Lock_Click(object sender, RoutedEventArgs e)
		{
			Plugin.Settings.Unlocked = !Plugin.Settings.Unlocked;
			Plugin.D.LockedText = Plugin.Settings.Unlocked ? "Lock" : "Unlock";
		}
	}
}
