using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ContactForm
{
    public partial class ContactDetails : ContentPage
    {
        readonly Person personObject;
        public ContactDetails(Person person)
        {
            InitializeComponent();
            personObject = person;
            headshot.Source = ImageSource.FromResource("ContactForm.Images." + person.HeadshotUrl);

            nameEntry.Text = person.Name;
            emailEntry.Text = person.Email;
            birthday.Date = person.Dob;
            favoriteSwitch.IsToggled = person.IsFavorite;
            genderPicker.SelectedIndex = (person.Gender == Gender.Male) ? 0 : 1;

            // Handle changes
            //nameEntry.TextChanged += (sender, e) => person.Name = nameEntry.Text;
            emailEntry.TextChanged += (sender, e) => person.Email = emailEntry.Text;
            birthday.DateSelected += (sender, e) => person.Dob = birthday.Date;
            favoriteSwitch.Toggled += (sender, e) => person.IsFavorite = favoriteSwitch.IsToggled;
            genderPicker.SelectedIndexChanged += (sender, e) => person.Gender = genderPicker.SelectedIndex == 0 ? Gender.Male : Gender.Female;
        }

        void OnShow(object sender, EventArgs e)
        {
            this.DisplayAlert("Selected Contact", personObject.ToString(), "OK");
        }
    }
}
