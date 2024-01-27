using ExchangeRate.Models;
using ExchangeRate.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate.ViewModel
{
    public partial class ValutesViewModel : BaseViewModel
    {
        ValuteService _valuteService;
        public ObservableCollection<Valute> Valutes { get; } = new();


        async Task GetValutesAsync()
        {
            var valutes = await 
        }

    }
}
