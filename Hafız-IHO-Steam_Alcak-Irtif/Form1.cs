using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafız_IHO_Steam_Alcak_Irtif
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        #region Unnamed Variables
        string dataIn;
        string LogFilePath = "../../../Logs/Data-Log.txt";
        string errLogFilePath = "../../../Logs/Error-Log.txt";

        sbyte index_of_gx, index_of_gy, index_of_gz,
                index_of_enlem, index_of_boylam,
                index_of_kurtarma1, index_of_kurtarma2,
                index_of_gps_error;
        string gyroX, gyroY, gyroZ;
        #endregion

        private void map_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();
            ComPortBox.Items.AddRange(portNames);
            ComPortBox.Text = portNames[0];
            map.MapProvider = GMapProviders.GoogleMap;
            map.MinZoom = 10;
            map.MaxZoom = 1000;
            map.Zoom = 15;
            map.Position = new GMap.NET.PointLatLng(40.85058547274375, 31.150151809552007);

            //map.DragButton = MouseButtons.Left;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        #region Com Port Open
        private void ComPortOpenButton_Click_1(object sender, EventArgs e)
        {
            ComPortOpen();
        }

        private void ComPortOpen()
        {
            try
            {
                seriP1.PortName = ComPortBox.Text;
                seriP1.Open();
                ComPortStatus.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Bir hatanız var!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Com Port Close
        private void ComPortCloseButton_Click(object sender, EventArgs e)
        {
            ComPortClose();
        }

        private void ComPortClose()
        {
            if (seriP1.IsOpen){
                seriP1.Close();
            }
            else
            {
                MessageBox.Show("Seri port zaten kapalı.", "Seri Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ComPortStatus.Value = 0;
        }
        #endregion

        #region Data in, print and processing

        #region Veri alma
        private void seriP1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            dataIn = seriP1.ReadExisting(); //Örnek gelen veri - N21,103M32,024V15,320I40,8401U31,1512RTD

            #region index of
            index_of_gx = Convert.ToSByte(dataIn.IndexOf('N'));
            index_of_gy = Convert.ToSByte(dataIn.IndexOf('M'));
            index_of_gz = Convert.ToSByte(dataIn.IndexOf('V'));

            index_of_enlem = Convert.ToSByte(dataIn.IndexOf('I'));
            index_of_boylam = Convert.ToSByte(dataIn.IndexOf('U'));

            index_of_kurtarma1 = Convert.ToSByte(dataIn.IndexOf('R'));
            index_of_kurtarma2 = Convert.ToSByte(dataIn.IndexOf('T'));
            index_of_gps_error = Convert.ToSByte(dataIn.IndexOf('D'));
            #endregion

            DataProcessing();
            LogData();
            this.Invoke(new EventHandler(ShowData));
        }
        #endregion

        #region Veri kayıt etme
        private void LogData() {
            try {
                File.AppendAllText(LogFilePath, $"{dataIn}  |  {DateTime.Now} \n");
            }
            catch (Exception err)
            {
                File.AppendAllText(errLogFilePath, $"Log Error || {dataIn}  |  {DateTime.Now} \n");
            }
        }
        #endregion

        #region Veri ekrana yazdırma
        private void ShowData(object sender, EventArgs e) {

            #region Gyro
            try
            {
                if (index_of_gx >= 0 && index_of_gy >= 0 && index_of_gz >= 0)
                {
                    gyroX = dataIn.Substring(index_of_gx + 1, (index_of_gy - index_of_gx) - 2);
                    lblGX.Text = gyroX;

                    gyroY = dataIn.Substring(index_of_gy + 1, (index_of_gz - index_of_gy) - 2);
                    lblGY.Text = gyroY;

                    gyroZ = dataIn.Substring(index_of_gz + 1, 5);
                    lblGZ.Text = gyroZ;
                }
            }
            catch (Exception err)
            {
                File.AppendAllText(errLogFilePath, $"Gyro - {err.Message}  |  {DateTime.Now} \n");
            }

            #endregion

        }
        #endregion

        #region Veri işleme
        private void DataProcessing()
        {
            #region GMap
            try
            {
                if (index_of_enlem >= 0 && index_of_boylam >= 0)
                {
                    lblenlem.Text = dataIn.Substring(index_of_enlem + 1, (index_of_boylam - index_of_enlem) - 1);
                    lblboylam.Text = dataIn.Substring(index_of_boylam + 1, (index_of_boylam - index_of_enlem) - 1);
                    lblKonum.Text = $"Konum: {lblenlem.Text}/{lblboylam.Text}";
                }
                if (lblenlem.Text != "Enlem" && lblboylam.Text != "Boylam")
                {
                    map.MinZoom = 10;
                    map.MaxZoom = 1000;
                    map.Zoom = 15;
                    map.Position = new GMap.NET.PointLatLng(Convert.ToDouble(lblenlem.Text.Replace('.', ',')), Convert.ToDouble(lblboylam.Text.Replace('.', ',')));
                    label5.Text = map.Position.ToString();
                }
            }
            catch (Exception err)
            {
                File.AppendAllText(errLogFilePath, $"GMap.Net - {err.Message}  |  {DateTime.Now} \n");
            }
            #endregion

            #region gps error
            if (index_of_gps_error >= 0 ) {
                btnGpsErr.BackColor = Color.DarkOrange;
                btnGpsErr.Text = "GPS Bağlanmadı";
            }
            #endregion


            #region Kurtarmalar
            if (index_of_kurtarma1 >= 0)
            {
                stKurtarma.BackColor = Color.LawnGreen;
            }
            if (index_of_kurtarma2 >= 0)
            {
                ndKurtarma.BackColor = Color.LawnGreen;
            }
            if (stKurtarma.BackColor == Color.LawnGreen)
            {
                stKurtarma.Text = "Kurtarma Aktif";
            }
            if (ndKurtarma.BackColor == Color.LawnGreen)
            {
                ndKurtarma.Text = "Kurtarma Aktif";
            }
            #endregion
        }
        #endregion

        #endregion
    }
}