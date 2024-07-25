using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    class TodoModel: INotifyPropertyChanged
    {
        private bool _isDone;
        private string _text;

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public bool IsDone
		{
			get { return _isDone; }
			set {
				if (_isDone==value)
					return;
					_isDone = value;
				onPropertyChanded("IsDone");
				}
		}

        public string Text
		{
			get { return _text; }
			set {
				if (_text == value) return;
				_text = value;
                onPropertyChanded("Text");

                }
		}

        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void onPropertyChanded(string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		}
    }
}
