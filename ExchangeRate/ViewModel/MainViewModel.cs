using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace ExchangeRate.ViewModel
{ 
    public class MainViewModel : BaseViewModel
    {
   

        public string _currencySrc;
        //public string CurrencySrc { get { return _currencySrc};
        //    set { _currencySrc = value;
        //    OnPropertyChanged} };


        void SelectedCurrencySrcChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                _currencySrc = picker.Items[selectedIndex];
            }
        }
    }
}
