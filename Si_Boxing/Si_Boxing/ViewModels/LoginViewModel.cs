using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Si_Boxing.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        #region Properties
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsRunning { get; set; }
        public bool IsRemember { get; set; }

        #endregion

        #region Commands

        public ICommand LoginCommand {

            get
            {
                return new RelayCommand(Login);
            }
        }
        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email",
                    "Acept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an password",
                    "Acept");
                return;
            }

        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemember = true;

        }
        
        #endregion
    }

}
