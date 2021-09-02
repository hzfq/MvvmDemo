using System;
using System.Collections.Generic;
using MvvmDemo.Config;

namespace MvvmDemo.Model
{
    public class Slider : PropertyChangeHandler
    {
        private int _initValue;
        private bool _boolValue;
        private string _stringValue;
        private DateTime _addDateTime;

        public int InitValue
        {
            get => _initValue;
            set
            {
                if (_initValue == value) return;
                _initValue = value;
                RaisePropertyChanged("InitValue");
            }
        }

        public bool BoolValue
        {
            get => _boolValue;
            set
            {
                if (_boolValue == value) return;
                _boolValue = value;
                RaisePropertyChanged("BoolValue");
            }
        }

        public string StringValue
        {
            get => _stringValue;
            set
            {
                if (_stringValue == value) return;
                _stringValue = value;
                RaisePropertyChanged("StringValue");
            }
        }

        public DateTime AddDateTime
        {
            get => _addDateTime;
            set
            {
                if (_addDateTime == value) return;
                _addDateTime = value;
                RaisePropertyChanged("AddDateTime");
            }
        }

        public static IEnumerable<Slider> GetSliders()
        {
            var rand = new Random(DateTime.Now.Millisecond);
            for (var i = 0; i < 10; i++)
            {
                yield return new Slider()
                {
                    AddDateTime = DateTime.Now,
                    StringValue = "字符串测试 " + i.ToString("D2"),
                    InitValue = rand.Next(1000, 9999),
                    BoolValue = (rand.Next(0, 10) > 5),
                };
            }
        }

        public static Slider GetNew()
        {
            var rand = new Random(DateTime.Now.Millisecond);
            return new Slider()
            {
                AddDateTime = DateTime.Now,
                StringValue = "字符串测试 " + rand.Next(10, 99).ToString("D2"),
                InitValue = rand.Next(1000, 9999),
                BoolValue = (rand.Next(0, 10) > 5),
            };
        }
    }
}