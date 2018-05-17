using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Si_Boxing.ViewModels
{
    using System.Windows.Input;

    public class LoginViewModel
    {
        #region Properties
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsRunning { get; set; }
        public bool IsRemember { get; set; }

        #endregion

        #region Commands

        public ICommand LoginCommand { get; set; }

        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemember = true;

        }
        #endregion
    }

}
