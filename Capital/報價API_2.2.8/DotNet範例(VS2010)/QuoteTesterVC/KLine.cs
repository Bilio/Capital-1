using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuoteTester
{
    public partial class KLine : UserControl
    {
        public KLine()
        {
            InitializeComponent();

            FillData();
        }


        private void FillData()
        {
            Random rand;
            // Use a number to calculate a starting value for 
            // the pseudo-random number sequence
            rand = new Random();

            // The number of days for stock data
            int period = 60;

            // The first High value
            double high = rand.NextDouble() * 40;

            // The first Close value
            double close = high - rand.NextDouble();

            // The first Low value
            double low = close - rand.NextDouble();

            // The first Open value
            double open = (high - low) * rand.NextDouble() + low;

            // The first Volume value
            double volume = 100 + 15 * rand.NextDouble();

            // The first day X and Y values
            chart1.Series["Price"].Points.AddXY(DateTime.Parse("1/2/2002"), high);
            chart1.Series["Volume"].Points.AddXY(DateTime.Parse("1/2/2002"), volume);
            chart1.Series["Price"].Points[0].YValues[1] = low;

            // The Open value is not used.
            chart1.Series["Price"].Points[0].YValues[2] = open;
            chart1.Series["Price"].Points[0].YValues[3] = close;

            // Days loop
            for (int day = 1; day <= period; day++)
            {

                // Calculate High, Low and Close values
                high = chart1.Series["Price"].Points[day - 1].YValues[2] + rand.NextDouble();
                close = high - rand.NextDouble();
                low = close - rand.NextDouble();
                open = (high - low) * rand.NextDouble() + low;

                // Calculate volume
                volume = chart1.Series["Volume"].Points[day - 1].YValues[0] + 10 * rand.NextDouble() - 5;

                // The low cannot be less than yesterday close value.
                if (low > chart1.Series["Price"].Points[day - 1].YValues[2])
                    low = chart1.Series["Price"].Points[day - 1].YValues[2];

                // Set data points values
                chart1.Series["Price"].Points.AddXY(day, high);
                chart1.Series["Price"].Points[day].XValue = chart1.Series["Price"].Points[day - 1].XValue + 1;
                chart1.Series["Price"].Points[day].YValues[1] = low;
                chart1.Series["Price"].Points[day].YValues[2] = open;
                chart1.Series["Price"].Points[day].YValues[3] = close;

                // Set volume values
                chart1.Series["Volume"].Points.AddXY(day, volume);
                chart1.Series["Volume"].Points[day].XValue = chart1.Series["Volume"].Points[day - 1].XValue + 1;
            }
        }
    }
}
