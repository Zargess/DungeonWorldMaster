﻿using Dungeon_World_Master.Common;
using Dungeon_World_Master.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Dungeon_World_Master
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class CharacterPage : Page
    {

        private NavigationHelper navigationHelper;

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public CharacterPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            this.DataContext = App.ViewModel;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="Common.NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="Common.SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="Common.NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="Common.NavigationHelper.LoadState"/>
        /// and <see cref="Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            App.ViewModel.SelectedNote = null;
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            App.ViewModel.SelectedNote = null;
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listbox = sender as ListBox;
            if (listbox == null) return;
            var note = listbox.SelectedItem as Note;
            if (note == null) return;
            App.ViewModel.SelectedNote = note;
        }

        private void Add_Note_Pressed(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;
            App.ViewModel.SelectedCharacter.Notes.Add(new Note("Add a title", "Add a body text"));
        }

        private void Remove_Note_Pressed(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;
            App.ViewModel.SelectedCharacter.Notes.Remove(App.ViewModel.SelectedNote);
            App.ViewModel.SelectedNote = null;
        }

        private void Reload(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;
            var _Frame = Window.Current.Content as Frame;
            _Frame.Navigate(_Frame.Content.GetType());
            _Frame.GoBack(); // remove from BackStack
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var box = sender as TextBox;
            var selectedIndex = NotesHandler.SelectedIndex;
            var note = App.ViewModel.SelectedCharacter.Notes[selectedIndex];
            note.Title = box.Text;
            var notes = new ObservableCollection<Note>();
            foreach (var item in App.ViewModel.SelectedCharacter.Notes)
            {
                notes.Add(item);
            }
            App.ViewModel.SelectedCharacter.Notes = notes;
            NotesHandler.SelectedIndex = selectedIndex;
        }

        
    }
}
