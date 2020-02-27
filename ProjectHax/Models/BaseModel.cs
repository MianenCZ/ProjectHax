using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProjectHax.Models
{
	public abstract class BaseModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string name)
		{
			System.Windows.Application.Current.Dispatcher.InvokeAsync(delegate {
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
			});
		}
	}
}
