using NoteKeeper.ViewModels;
using System.ComponentModel;
using NoteKeeper.Models;
using Xamarin.Forms;
using System;
using NoteKeeper.Services;
using System.Collections.Generic;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {

        ItemDetailViewModel viewModel;

        public ItemDetailPage()
        {
            InitializeComponent();
            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
        }


        public void Cancel_Clicked(object sender,EventArgs eventArgs)
        {
            viewModel.NoteHeading = "XXXXXXX";
            DisplayAlert("Cancel option", 
                "Heading value is " + viewModel.Note.Heading, 
                "Button 2", 
                "Button 1"
            );
        }

        public void Save_Clicked(object sender, EventArgs eventArgs)
        {   
            
            DisplayAlert("Save option", "Save was selected", "Button 2", "Button 1");
        }
    }
}