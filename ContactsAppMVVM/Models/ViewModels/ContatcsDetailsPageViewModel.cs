﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ContactsAppMVVM.Models.ViewModels
{
    partial class ContatcsDetailsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Contact? contact;

    }
}
