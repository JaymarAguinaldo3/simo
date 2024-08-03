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
using Authenti_Gate.AdminScan.Guest;
using MySqlConnector;

namespace Authenti_Gate.AdminScan
{
    public partial class ScanForm : Form
    {
        string PrfidData = " ";
        string VrfidData = " ";

        SerialPort serialPort1 = new SerialPort();
        SerialPort serialPort2 = new SerialPort();
        public void StudLogs()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                string cmm = "INSERT into studlogs_table (ID_Number,Full_Name,Program,Year,Section,Log_date,Time_in) VALUES(@ID_Number,@Full_Name,@Program,@Year,@Section,@Log_date,@Time_in)";
                var cmds = new MySqlCommand(cmm, con);
                cmds.Parameters.AddWithValue("@ID_Number", labelID.Text);
                cmds.Parameters.AddWithValue("@Full_Name", labelName.Text);
                cmds.Parameters.AddWithValue("@Program", labelCollege.Text);
                cmds.Parameters.AddWithValue("@Year", labelYear.Text);
                cmds.Parameters.AddWithValue("@Section", labelSection.Text);
                cmds.Parameters.AddWithValue("@Log_date", labelDate.Text);
                cmds.Parameters.AddWithValue("@Time_in", labelTime.Text);
                cmds.ExecuteNonQuery();

                MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelID.Text = "ID Number";
                labelName.Text = "Full Name";
                labelCollege.Text = "Program";
                labelPos.Text = "Position";
                tbPrfid.Text = null;
                labelYear.Text = "Year";
                labelSection.Text = "Section";
                labelDate.Text = "Date";
                labelTime.Text = "Time";
                pictureBox1.Image = Properties.Resources.Splash_AG;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void UStud()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                string cmm = "UPDATE studlogs_table SET Time_out = '" + labelTime.Text + "' WHERE  ID_Number ='" + labelID.Text + "' AND Log_Date = '" + labelDate.Text + "' AND Time_out = '" + " " + "'";
                var cmds = new MySqlCommand(cmm, con);
                cmds.ExecuteNonQuery();

                MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelID.Text = "ID Number";
                labelName.Text = "Full Name";
                labelCollege.Text = "Program";
                labelPos.Text = "Position";
                tbPrfid.Text = null;
                labelYear.Text = "Year";
                labelSection.Text = "Section";
                labelDate.Text = "Date";
                labelTime.Text = "Time";
                pictureBox1.Image = Properties.Resources.Splash_AG;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void FacLogs()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                string cmm = "INSERT into facultylogs_table (ID_Number,Full_Name,Program,Log_date,Time_in) VALUES(@ID_Number,@Full_Name,@Program,@Log_date,@Time_in)";
                var cmds = new MySqlCommand(cmm, con);
                cmds.Parameters.AddWithValue("@ID_Number", labelID.Text);
                cmds.Parameters.AddWithValue("@Full_Name", labelName.Text);
                cmds.Parameters.AddWithValue("@Program", labelCollege.Text);
                cmds.Parameters.AddWithValue("@Log_date", labelDate.Text);
                cmds.Parameters.AddWithValue("@Time_in", labelTime.Text);
                cmds.ExecuteNonQuery();

                MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelID.Text = "ID Number";
                labelName.Text = "Full Name";
                labelCollege.Text = "Program";
                labelPos.Text = "Position";
                tbPrfid.Text = null;
                labelYear.Text = "Year";
                labelSection.Text = "Section";
                labelDate.Text = "Date";
                labelTime.Text = "Time"; 
                pictureBox1.Image = Properties.Resources.Splash_AG;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void UFaculty()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                string cmm = "UPDATE facultylogs_table SET Time_out = '" + labelTime.Text + "' WHERE  ID_Number ='" + labelID.Text + "' AND Log_Date = '" + labelDate.Text + "' AND Time_out = '" + " " + "'";
                var cmds = new MySqlCommand(cmm, con);
                cmds.ExecuteNonQuery();

                MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelID.Text = "ID Number";
                labelName.Text = "Full Name";
                labelCollege.Text = "Program";
                labelPos.Text = "Position";
                tbPrfid.Text = null;
                labelYear.Text = "Year";
                labelSection.Text = "Section";
                labelDate.Text = "Date";
                labelTime.Text = "Time";
                pictureBox1.Image = Properties.Resources.Splash_AG;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void FCStaffLogs()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                string cmm = "INSERT into fcstafflogs_table (ID_Number,Full_Name,Role,Log_date,Time_in) VALUES(@ID_Number,@Full_Name,@Role,@Log_date,@Time_in)";
                var cmds = new MySqlCommand(cmm, con);
                cmds.Parameters.AddWithValue("@ID_Number", labelID.Text);
                cmds.Parameters.AddWithValue("@Full_Name", labelName.Text);
                cmds.Parameters.AddWithValue("@Role", labelPos.Text);
                cmds.Parameters.AddWithValue("@Log_date", labelDate.Text);
                cmds.Parameters.AddWithValue("@Time_in", labelTime.Text);
                cmds.ExecuteNonQuery();

                MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelID.Text = "ID Number";
                labelName.Text = "Full Name";
                labelCollege.Text = "Program";
                labelPos.Text = "Position";
                tbPrfid.Text = null;
                labelYear.Text = "Year";
                labelSection.Text = "Section";
                labelDate.Text = "Date";
                labelTime.Text = "Time";
                pictureBox1.Image = Properties.Resources.Splash_AG;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void UFCStaff()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                string cmm = "UPDATE fcstafflogs_table SET Time_out = '" + labelTime.Text + "' WHERE  ID_Number ='" + labelID.Text + "' AND Log_Date = '" + labelDate.Text + "' AND Time_out = '" + " " + "'";
                var cmds = new MySqlCommand(cmm, con);
                cmds.ExecuteNonQuery();

                MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelID.Text = "ID Number";
                labelName.Text = "Full Name";
                labelCollege.Text = "Program";
                labelPos.Text = "Position";
                tbPrfid.Text = null;
                labelYear.Text = "Year";
                labelSection.Text = "Section";
                labelDate.Text = "Date";
                labelTime.Text = "Time";
                pictureBox1.Image = Properties.Resources.Splash_AG;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void StaffLogs()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                string cmm = "INSERT into stafflogs_table (ID_Number,Full_Name,Role,Log_date,Time_in) VALUES(@ID_Number,@Full_Name,@Role,@Log_date,@Time_in)";
                var cmds = new MySqlCommand(cmm, con);
                cmds.Parameters.AddWithValue("@ID_Number", labelID.Text);
                cmds.Parameters.AddWithValue("@Full_Name", labelName.Text);
                cmds.Parameters.AddWithValue("@Role", labelPos.Text);
                cmds.Parameters.AddWithValue("@Log_date", labelDate.Text);
                cmds.Parameters.AddWithValue("@Time_in", labelTime.Text);
                cmds.ExecuteNonQuery();

                MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelID.Text = "ID Number";
                labelName.Text = "Full Name";
                labelCollege.Text = "Program";
                labelPos.Text = "Position";
                tbPrfid.Text = null;
                labelYear.Text = "Year";
                labelSection.Text = "Section";
                labelDate.Text = "Date";
                labelTime.Text = "Time";
                pictureBox1.Image = Properties.Resources.Splash_AG;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void UStaff()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                string cmm = "UPDATE staflogs_table SET Time_out = '" + labelTime.Text + "' WHERE  ID_Number ='" + labelID.Text + "' AND Log_Date = '" + labelDate.Text + "' AND Time_out = '" + " " + "'";
                var cmds = new MySqlCommand(cmm, con);
                cmds.ExecuteNonQuery();

                MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelID.Text = "ID Number";
                labelName.Text = "Full Name";
                labelCollege.Text = "Program";
                labelPos.Text = "Position";
                tbPrfid.Text = null;
                labelYear.Text = "Year";
                labelSection.Text = "Section";
                labelDate.Text = "Date";
                labelTime.Text = "Time";
                pictureBox1.Image = Properties.Resources.Splash_AG;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void FStaffScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT ID_Number, Full_Name, Role, Picture FROM foodcourtstaff_table WHERE RFID_tag = '" + tbPrfid.Text + "'", con);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    labelID.Text = reader["ID_Number"].ToString();
                    labelName.Text = reader["Full_Name"].ToString();
                    labelPos.Text = reader["Role"].ToString();
                    labelCollege.Text = "College";
                    labelYear.Text = "Year";
                    labelSection.Text = "Section";
                    labelDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                    labelTime.Text = DateTime.Now.ToString("hh:mm tt");

                    Byte[] img = (Byte[])reader["Picture"];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void StaffScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT ID_Number, Full_Name, Role, Picture FROM staff_table WHERE RFID_tag = '" + tbPrfid.Text + "'", con);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    labelID.Text = reader["ID_Number"].ToString();
                    labelName.Text = reader["Full_Name"].ToString();
                    labelPos.Text = reader["Role"].ToString();
                    labelCollege.Text = "College";
                    labelYear.Text = "Year";
                    labelSection.Text = "Section";
                    labelDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                    labelTime.Text = DateTime.Now.ToString("hh:mm tt");

                    Byte[] img = (Byte[])reader["Picture"];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void StudScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT ID_Number, Full_Name, Program, Year, Section, Role, Picture FROM studinfo_table WHERE RFID_tag = '" + tbPrfid.Text + "'", con);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    labelID.Text = reader["ID_Number"].ToString();
                    labelName.Text = reader["Full_Name"].ToString();
                    labelCollege.Text = reader["Program"].ToString();
                    labelYear.Text = reader["Year"].ToString();
                    labelSection.Text = reader["Section"].ToString();
                    labelPos.Text = reader["Role"].ToString();
                    labelDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                    labelTime.Text = DateTime.Now.ToString("hh:mm tt");

                    Byte[] img = (Byte[])reader["Picture"];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void FacScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT ID_Number, Full_Name,Program, Role, Picture FROM faculty_table WHERE RFID_tag = '" + tbPrfid.Text + "'", con);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    labelID.Text = reader["ID_Number"].ToString();
                    labelName.Text = reader["Full_Name"].ToString();
                    labelPos.Text = reader["Role"].ToString();
                    labelCollege.Text = reader["Program"].ToString();
                    labelYear.Text = "Year";
                    labelSection.Text = "Section";
                    labelDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                    labelTime.Text = DateTime.Now.ToString("hh:mm tt");

                    Byte[] img = (Byte[])reader["Picture"];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void VecScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Plate_Number, Owner_Name, Category, Model FROM vehicle_table WHERE RFID_tag = '" + tbVrfid.Text + "'", con);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    labelPlate.Text = reader["Plate_Number"].ToString();
                    labelOwner.Text = reader["Owner_Name"].ToString();
                    labelCategory.Text = reader["Category"].ToString();
                    labelModel.Text = reader["Model"].ToString();
                    labelVDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                    labelVTime.Text = DateTime.Now.ToString("hh:mm tt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void Veclogs()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                string cmm = "INSERT into passedvehicle_table (Plate_Number,Owner_Name,Category,Model,Log_date,Time_In) VALUES(@Plate_Number,@Owner_Name,@Category,@Model,@Log_date,@Time_In)";
                var cmds = new MySqlCommand(cmm, con);
                cmds.Parameters.AddWithValue("@Plate_Number", labelPlate.Text);
                cmds.Parameters.AddWithValue("@Owner_Name", labelOwner.Text);
                cmds.Parameters.AddWithValue("@Category", labelCategory.Text);
                cmds.Parameters.AddWithValue("@Model", labelModel.Text);
                cmds.Parameters.AddWithValue("@Log_date", labelVDate.Text);
                cmds.Parameters.AddWithValue("@Time_In", labelVTime.Text);
                cmds.ExecuteNonQuery();

                MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelPlate.Text = "Plate Number";
                labelOwner.Text = "Owner Name";
                labelCategory.Text = "Category";
                labelModel.Text = "Model";
                labelVDate.Text = "Date";
                labelVTime.Text = "Time";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void UVec()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                string cmm = "UPDATE passedvehicle_table SET Time_Out = '" + labelVTime.Text + "' WHERE  Plate_Number ='" + labelPlate.Text + "' AND Log_Date = '" + labelVDate.Text + "' AND Time_out = '" + " " + "'";
                var cmds = new MySqlCommand(cmm, con);
                cmds.ExecuteNonQuery();

                MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelPlate.Text = "Plate Number";
                labelOwner.Text = "Owner Name";
                labelCategory.Text = "Category";
                labelModel.Text = "Model";
                labelVDate.Text = "Date";
                labelVTime.Text = "Time";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public ScanForm()
        {
            InitializeComponent();
            serialPort1.PortName = "COM1";
            serialPort1.BaudRate = 9600;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

            serialPort2.PortName = "COM2";
            serialPort2.BaudRate = 9600;
            serialPort2.DataReceived += new SerialDataReceivedEventHandler(serialPort2_DataReceived);
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string PrfidData = serialPort1.ReadLine();

            tbPrfid.Text = PrfidData;
        }
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string VrfidData = serialPort1.ReadLine();

            tbVrfid.Text = VrfidData;

        }
        private void guestBtn_Click(object sender, EventArgs e)
        {
            GuestForm guestForm = new GuestForm();
            guestForm.Show();
        }

        private void ScanForm_Load(object sender, EventArgs e)
        {
            string[] availablePorts = SerialPort.GetPortNames();


            if (Array.Exists(availablePorts, port => port == serialPort1.PortName))
            {
                try
                {
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening serial port 1: " + ex.Message);
                }
            }

            if (Array.Exists(availablePorts, port => port == serialPort2.PortName))
            {
                try
                {
                    serialPort2.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening serial port 2: " + ex.Message);
                }
            }
        }

        private void tbPrfid_TextChanged(object sender, EventArgs e)
        {
            FacScan();
            FStaffScan();
            StaffScan();
            StudScan();
        }

        private void tbVrfid_TextChanged(object sender, EventArgs e)
        {
            VecScan();
        }

        private void btnLoginP_Click(object sender, EventArgs e)
        {
            if (tbPrfid.Text == " ")
            {
                MessageBox.Show("Please scan a RFID card", "Scan Rfid");
            }
            else
            {
                if (labelPos.Text == "Student")
                {
                    StudLogs();
                }
                else if (labelPos.Text == "Faculty")
                {
                    FacLogs();
                }
                else if (labelPos.Text == "Staff")
                {
                    StaffLogs();
                }
                else if (labelPos.Text == "Food Court Staff")
                {
                    FCStaffLogs();
                }
            }
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            if (tbVrfid.Text == null)
            {
                MessageBox.Show("Please scan a RFID card", "Scan Rfid");
            }
            else
            {
                Veclogs();
            }
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            if (tbVrfid.Text == null)
            {
                MessageBox.Show("Please scan a RFID card", "Scan Rfid");
            }
            else
            {
                UVec();
            }
        }

        private void btnLogoutP_Click(object sender, EventArgs e)
        {
            if (tbPrfid.Text == null)
            {
                MessageBox.Show("Please scan a RFID card", "Scan Rfid");
            }
            else
            {
                if (labelPos.Text == "Student")
                {
                    UStud();
                }
                else if (labelPos.Text == "Faculty")
                {
                    UFaculty();
                }
                else if (labelPos.Text == "Staff")
                {
                    UStaff();
                }
                else if (labelPos.Text == "Food Court Staff")
                {
                    UFCStaff();
                }
            }
        }
    }
}
