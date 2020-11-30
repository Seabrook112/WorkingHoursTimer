using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingHoursTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(_timer_Tick);
        }

        private Timer _timer;
        private string _Start = null;
        private DateTime _startTime = DateTime.MinValue;
        private TimeSpan _currentElapsedTime = TimeSpan.Zero;
        private TimeSpan _totalElapsedTime = TimeSpan.Zero;
        private bool _timerRunning = false;
       
        void _timer_Tick(object sender, EventArgs e)
        {
            var timeSinceStartTime = DateTime.Now - _startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);
            _currentElapsedTime = timeSinceStartTime + _totalElapsedTime;
            _totalElapsedTimeDisplay.Text = _currentElapsedTime.ToString();
            _currentElapsedTimeDisplay.Text = timeSinceStartTime.ToString();
        }

       
        private void startButton_Click(object sender, EventArgs e)
        {
            if(_Start == null)
                _Start = DateTime.Now.ToString();
            if (!_timerRunning)
            {
                _startTime = DateTime.Now;
                _totalElapsedTime = _currentElapsedTime;
                _timer.Start();
                _timerRunning = true;
                this.StartStop.Text = "Pause";
            }
            else 
            {
                _timer.Stop();
                _timerRunning = false;
                this.StartStop.Text = "Start";
            }
        }

        

        private void submitButton_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _timerRunning = false;
            SubmitTimeSheet(_currentElapsedTime);
            _totalElapsedTime = TimeSpan.Zero;
            _currentElapsedTime = TimeSpan.Zero;
            _totalElapsedTimeDisplay.Text = _currentElapsedTime.ToString();
            _currentElapsedTimeDisplay.Text = "00:00:00";
            _Start = null;
            this.StartStop.Text = "Start";
        }

        private void SubmitTimeSheet(TimeSpan totalElapsedTime)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@TotalTime",totalElapsedTime.ToString()),
                new SqlParameter("@StartTime",_Start),
                new SqlParameter("@EndTime",DateTime.Now.ToString()),
            };
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlcmd = new SqlCommand("usp_InsertTimeSheet", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                foreach (var parameter in parameters)
                    sqlcmd.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    //ignore
                }
            }
        }

        private string ConnectionString = $"Data Source=src" +
                               ";Persist Security Info=True" +
                               $";Password=password" +
                               $";User ID=userID" +
                               $";Initial Catalog=Database" +
                               $";Connection Timeout=30";
    }
}
