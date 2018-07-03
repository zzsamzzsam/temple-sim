using System;
using System.Collections.Generic;

namespace PTS
{
    public partial class Form : System.Windows.Forms.Form
    {
        List<List<Room>> rss = new List<List<Room>>();

        public Form()
        {
            InitializeComponent();
        }

        private void PathTemples_Load(object sender, EventArgs e)
        {

        }

        private void runsim_Click(object sender, EventArgs e)
        {
            List<Room> rs = new List<Room>();
            List<StringValue> rr = new List<StringValue>();

            rs.Clear();
            rr.Clear();

            int a = roomscb.SelectedIndex;
            a = a == 0 ? 24 : 22;

            int sum = 0;
            for (int k = 0; k < 10; k++)
            {
                sum = 0;
                for (int j = 0; j < 1000000; j++)
                {
                    Temple t = new Temple(a);
                    t.populateRandom(fiftyFifty(11));

                    int i = 0;
                    while (i < 11)
                    {
                        i += t.runIncursion();
                    }

                    if (t.hasRoom())
                    {
                        rs.AddRange(t.rooms);
                        sum++;
                    }
                }
                rr.Add(new StringValue(sum.ToString()));
            }

            dataGrid.DataSource = rr;
        }

        private int fiftyFifty(int n)
        {
            Random r = new Random();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += r.Next(2);
            }
            return sum;
        }
    }

    public class StringValue
    {
        public StringValue(string s)
        {
            _value = s;
        }
        public string Value { get { return _value; } set { _value = value; } }
        string _value;
    }
}
