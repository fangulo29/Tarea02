using Lab01.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Lab01.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Person> _vloListaPersona = new ObservableCollection<Person>();

        public ObservableCollection<Person> vloListaPersona
        {
            get
            {
                return _vloListaPersona;
            }
            set
            {
                _vloListaPersona = value;
                OnPropertyChanged("vloListaPersona");
            }
        }

        public PersonViewModel()
        {
            InitClass();
        }

        public async void InitClass()
        {
            vloListaPersona = await Person.ObtenerPersonas();
        }

        #region INotifyPropertyChanged Interface

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs((propertyName)));
            }
        }

        #endregion  
    }
}
