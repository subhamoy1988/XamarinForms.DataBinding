//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactForm {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class ContactDetails : ContentPage {
        
        private ToolbarItem showButton;
        
        private Image headshot;
        
        private Entry nameEntry;
        
        private Entry emailEntry;
        
        private Picker genderPicker;
        
        private DatePicker birthday;
        
        private Switch favoriteSwitch;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(ContactDetails));
            showButton = this.FindByName<ToolbarItem>("showButton");
            headshot = this.FindByName<Image>("headshot");
            nameEntry = this.FindByName<Entry>("nameEntry");
            emailEntry = this.FindByName<Entry>("emailEntry");
            genderPicker = this.FindByName<Picker>("genderPicker");
            birthday = this.FindByName<DatePicker>("birthday");
            favoriteSwitch = this.FindByName<Switch>("favoriteSwitch");
        }
    }
}