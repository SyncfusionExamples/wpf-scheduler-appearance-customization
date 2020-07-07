using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AppointmentCustomization
{
    public class SubjectToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().Equals("Conference"))
                return "../Images/Conference_schedule.png";
            else if (value.ToString().Equals("System Troubleshoot"))
                return "../Images/Troubleshoot.png";
            else if (value.ToString().Equals("Checkup"))
                return "../Images/Stethoscope.png";
            else
                return "../Images/cake_schedule.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
