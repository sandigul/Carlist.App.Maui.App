using Carlist.App.Maui.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlist.App.Maui.ViewModels
{
    [QueryProperty(nameof(Car),"Car")]
    public partial class CarDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        Car car;

       
    }
}
