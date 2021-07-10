﻿using System;
using System.Windows;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Windows.Threading;
using System.Windows.Media;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using System.Globalization;
using System.ComponentModel;
using Microsoft.Win32;
using System.Windows.Input;
using System.Reflection;
using ControlzEx.Standard;
using System.Net;
using System.Threading.Tasks;
using MahApps.Metro.Controls;

namespace Dragoon_Modifier.UI {
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow {
        private static readonly SolidColorBrush _offColor = new SolidColorBrush(Color.FromArgb(255, 255, 168, 168));
        private static readonly SolidColorBrush _onColor = new SolidColorBrush(Color.FromArgb(255, 168, 211, 255));

        public static DraMod.UI.IUIControl UIControl;

        public MainWindow() {
            InitializeComponent();
            InitUI();
            this.Title += DraMod.Constants.Version;
            Console.SetOut(new TextBoxOutput(txtOutput));
            Debug.Listeners.Add(new DebugOutput(txtOutput));

            DraMod.Setup.Run(UIControl);
        }

        private void InitUI() {
            TextBlock[,] monsterLables = new TextBlock[5, 6] {
                {lblEnemy1Name,  lblEnemy1HP, lblEnemy1ATK, lblEnemy1DEF, lblEnemy1SPD, lblEnemy1TRN},
                {lblEnemy2Name,  lblEnemy2HP, lblEnemy2ATK, lblEnemy2DEF, lblEnemy2SPD, lblEnemy2TRN},
                {lblEnemy3Name,  lblEnemy3HP, lblEnemy3ATK, lblEnemy3DEF, lblEnemy3SPD, lblEnemy3TRN},
                {lblEnemy4Name,  lblEnemy4HP, lblEnemy4ATK, lblEnemy4DEF, lblEnemy4SPD, lblEnemy4TRN},
                {lblEnemy5Name,  lblEnemy5HP, lblEnemy5ATK, lblEnemy5DEF, lblEnemy5SPD, lblEnemy5TRN}
            };
            TextBlock[,] characterLables = new TextBlock[3, 9] {
                { lblCharacter1Name, lblCharacter1HMP, lblCharacter1ATK, lblCharacter1DEF, lblCharacter1VHIT, lblCharacter1DATK, lblCharacter1DDEF, lblCharacter1SPD, lblCharacter1TRN },
                { lblCharacter2Name, lblCharacter2HMP, lblCharacter2ATK, lblCharacter2DEF, lblCharacter2VHIT, lblCharacter2DATK, lblCharacter2DDEF, lblCharacter2SPD, lblCharacter2TRN },
                { lblCharacter3Name, lblCharacter3HMP, lblCharacter3ATK, lblCharacter3DEF, lblCharacter3VHIT, lblCharacter3DATK, lblCharacter3DDEF, lblCharacter3SPD, lblCharacter3TRN }
            };
            TextBlock[] fieldLables = new TextBlock[3] {
                lblEncounter, lblEnemyID, lblMapID
            };
            UIControl = Factory.UIControl(monsterLables, characterLables, stsGame, stsProgram, fieldLables);
            
        }

        private void miAttach_Click(object sender, RoutedEventArgs e) {
          
        }

        private void miEmulator_Click(object sender, RoutedEventArgs e) {
  
        }

        public void SetupEmulator(bool onOpen) {
       
        }

        public void SetupScripts() {

        }

        private void miRegion_Click(object sender, RoutedEventArgs e) {
  
        }

        private void miSaveSlot_Click(object sender, RoutedEventArgs e) {
   
        }

        private void miLog_Click(object sender, RoutedEventArgs e) {

        }

        private void btnField_Click(object sender, RoutedEventArgs e) {

        }

        private void btnBattle_Click(object sender, RoutedEventArgs e) {
  
        }

        private void btnHotkeys_Click(object sender, RoutedEventArgs e) {

        }

        private void btnOther_Click(object sender, RoutedEventArgs e) {
       
        }

        private void lstField_ScrollChanged(object sender, ScrollChangedEventArgs e) {

        }

        private void lstBattle_ScrollChanged(object sender, ScrollChangedEventArgs e) {
  
        }

        private void lstHotkey_ScrollChanged(object sender, ScrollChangedEventArgs e) {
 
        }

        private void lstOther_ScrollChanged(object sender, ScrollChangedEventArgs e) {
 
        }

        private void lstField_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e) {

        }

        private void lstBattle_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e) {

        }

        private void lstHotkey_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e) {
  
        }

        private void lstOther_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e) {
      
        }

        private void miNew_Click(object sender, RoutedEventArgs e) {

        }

        private void miOpen_Click(object sender, RoutedEventArgs e) {

        }

        private void miSave_Click(object sender, RoutedEventArgs e) {
            
        }

        private void miOpenPreset_Click(object sender, RoutedEventArgs e) {
            
        }

        private void miPresetHotkeys_Click(object sender, RoutedEventArgs e) {
            
        }

        private void miDeleteSave_Click(object sender, RoutedEventArgs e) {
 
        }

        private void miEatbSound_Click(object sender, RoutedEventArgs e) {
            
        }

        private void miManualOffset_Click(object sender, RoutedEventArgs e) {
            
        }


        private void miModOptions_Click(object sender, RoutedEventArgs e) {
            
        }

        private void miAuthor_Click(object sender, RoutedEventArgs e) {
         
        }

        private void miCredits_Click(object sender, RoutedEventArgs e) {
            
        }

        private void miCredits1_Click(object sender, RoutedEventArgs e) {
            
        }

        private void miCredits2_Click(object sender, RoutedEventArgs e) {
        }

        private void miCredits3_Click(object sender, RoutedEventArgs e) {
            
        }

        private void miCredits4_Click(object sender, RoutedEventArgs e) {
            
        }

        private void miVersion_Click(object sender, RoutedEventArgs e) {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
        }

        public void SwitchButton(object sender, EventArgs e) {
            Button btn = (Button) sender;
            switch (btn.Name) {
                case "btnKillBGM":
                    ToggleButton(ref btn, ref DraMod.Settings.KillBGM);
                    break;
                case "btnAutoTransform":
                    ToggleButton(ref btn, ref DraMod.Settings.AutoTransform);
                    break;
                case "btnSaveAnywhere":
                    ToggleButton(ref btn, ref DraMod.Settings.SaveAnywhere);
                    break;
                case "btnCharmPotion":
                    ToggleButton(ref btn, ref DraMod.Settings.AutoCharmPotion);
                    break;
                case "btnRemoveCaps":
                    ToggleButton(ref btn, ref DraMod.Settings.RemoveDamageCaps);
                    break;
                case "btnHPNames":
                    ToggleButton(ref btn, ref DraMod.Settings.MonsterHPAsNames);
                    break;
                case "btnNeverGuard":
                    ToggleButton(ref btn, ref DraMod.Settings.NeverGuard);
                    break;
                case "btnSoulEater":
                    ToggleButton(ref btn, ref DraMod.Settings.NoDecaySoulEater);
                    break;
            }
        }

        private void ToggleButton(ref Button sender, ref bool value) {
            if (!value) {
                sender.Background = _onColor;
            } else {
                sender.Background = _offColor;
            }
            value = !value;
        }

        public void GreenButton(object sender, EventArgs e) {

        }

        public void ComboBox(object sender, EventArgs e) {
        }

        public void DifficultyButton(object sender, EventArgs e) {

        }

        private void Slider_ValueChanged(object sender, EventArgs e) {

        }

        private void Window_Closing(object sender, CancelEventArgs e) {

        }

        private void Window_Closed(object sender, EventArgs e) {
        
        }

        public void CloseEmulator() {

        }
    }
}
