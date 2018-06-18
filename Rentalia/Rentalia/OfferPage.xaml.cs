﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Rentalia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rentalia
{


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferPage : ContentPage
    {
        public string Name { get; set; }
        public OfferPage()
        {
            BindingContext = this;
            InitializeComponent();
            //var items = Enumerable.Range(0, 10);
            Aanbieding[] alleAanbiedingen = new Aanbieding[] {new Aanbieding("veld", "veld", "veld", 69, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0) ), new Aanbieding("veld", "veld", "veld", 69, DateTime.Now, new Gebruiker("veld", "veld", "veld", "veld", "veld", DateTime.Now, 0, 0))};
            Array[] alleThumbnails = new Array[alleAanbiedingen.Length];
            int counter = 0;
            foreach (Aanbieding offer in alleAanbiedingen)
            {
                string[] thumbnail = new string[] { offer.Titel, offer.Huurprijs.ToString(), offer.Fotos[0].Bestandsnaam };
                alleThumbnails[counter] = thumbnail;
                Name = thumbnail[0];
                counter++;
            }
            listView.ItemsSource = alleThumbnails;
        }

        void OnImageTapped(object sender, EventArgs args)
        {
            var image = sender as Image;
            var viewCell = image.Parent.Parent as ViewCell;

            if (image.HeightRequest < 250)
            {
                image.HeightRequest = image.Height + 100;
                viewCell.ForceUpdateSize();
            }
        }

        public void OnClickMailBox()
        {
            App.Current.MainPage = new MessagePage();
        }
        public void OnClickOfferPage()
        {
            App.Current.MainPage = new OfferPage();
        }
        public void OnClickUserPage()
        {
            App.Current.MainPage = new UserPage();
        }
        public void OnClickHubPage()
        {
            App.Current.MainPage = new HubPage();
        }

        private void OnClickAddOffer(object sender, EventArgs e)
        {
            App.Current.MainPage = new AddOffer();
        }

    }

    
    };


    

