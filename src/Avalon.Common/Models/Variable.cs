﻿using Avalon.Common.Interfaces;
using System.ComponentModel;

namespace Avalon.Common.Models
{
    public class Variable : INotifyPropertyChanged, IVariable
    {
        public Variable()
        {

        }

        public Variable(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public Variable(string key, string value, string character)
        {
            this.Key = key;
            this.Value = value;
            this.Character = character;
        }

        private string _key = "";
        public string Key
        {
            get => _key;
            set
            {
                _key = value;
                OnPropertyChanged("Key");
            }
        }

        private string _value = "";
        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        public string Character { get; set; } = "";

        protected virtual async void OnPropertyChanged(string propertyName)
        {
            var e = new PropertyChangedEventArgs(propertyName);
            PropertyChanged?.Invoke(this, e);
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
