using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHax.Models
{
	public class ShellModel : BaseModel
	{
        private string inText;
        public string InText
        {
            get { return inText; }
            set
            {
                inText = value;
                OnPropertyChanged(nameof(InText));
            }
        }

        private string outText;
        public string OutText
        {
            get { return outText; }
            set
            {
                outText = value;
                OnPropertyChanged(nameof(OutText));
            }
        }

        private int fontSize;
        public int FontSize
        {
            get { return fontSize; }
            set
            {
                fontSize = value;
                OnPropertyChanged(nameof(FontSize));
            }
        }

        private string fontFamily;
        public string FontFamily
        {
            get { return fontFamily; }
            set
            {
                fontFamily = value;
                OnPropertyChanged(nameof(FontFamily));
            }
        }
    }
}
