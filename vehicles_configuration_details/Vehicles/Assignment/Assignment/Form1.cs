using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Assignment
{
    public partial class Form1 : Form
    {
        OpenFileDialog OpenFile = new OpenFileDialog();
        string line = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFile.Filter = "Xml Files (.xml)|*.xml";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // To clear changes from previous load button press. 
            ErrorBox.Clear();
            //listBox1.Items.Clear();

            listBox.Items.Clear();
            //comboBox1.Items.Clear();  --> combo Box is not cleared else, it will only show vehicles from the Xml file and not from database. since query is run on database, the comboBox need to show all the vehicles in the database.


            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                // the following commented code was to display the file contents in XML format in listbox in GUI
                /*
                StreamReader sr = new StreamReader(OpenFile.FileName);
                List<int> list = new List<int>();

                
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        //listBox1.Items.Add(line);

                    }
                 
                } 
                sr.Close(); */

                try
                {
                    // Check we actually have a value
                    if (string.IsNullOrEmpty(OpenFile.FileName) == false)
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load(OpenFile.FileName);

                        //XmlNodeList nodelist = doc.SelectNodes("/VehicleConfigurationDetails/vehicle"); // get all <vehicle> nodes inside root node <VehicleConfigurationDetails>

                        // instead of using nodelist where the xml file won't load if the root node name is changed use the following code.
                        foreach (XmlNode node in /*nodelist*/ doc.DocumentElement)
                        {
                            // extract data from vehicle.xml file
                            string Engine = node["engine"].InnerText;
                            string VehicleID = node["vehicleID"].InnerText;
                            int Range = int.Parse(node["range"].InnerText);
                            int Weight = int.Parse(node["weight"].InnerText);
                            int CarryCapacity = int.Parse(node["carryCapacity"].InnerText);
                            float Topspeed = float.Parse(node["topspeed"].InnerText);

                            listBox.Items.Add(new vehicle(Engine, VehicleID, Range, Weight, CarryCapacity, Topspeed));

                            // insert into Vehicle table in courseowrkdb.db database
                            string temp9 = "INSERT INTO vehicle(engine, vehicleID, range, weight, carryCapacity, topspeed) VALUES('" + Engine + " ', '" + VehicleID + "', " + Range + "," + Weight + ", " + CarryCapacity + " , " + Topspeed + "); ";
                            string r9 = dbAccess.sqlChange(temp9);

                            // Novice user time duration
                            // Populate the comboBox with vehicleID from vehicle table in the SQLite database.
                            comboBox1.Items.Add(VehicleID);

                            if (node["engine"].InnerText == "Petrol")
                            {
                                int Noise = int.Parse(node["noise"].InnerText);
                                int Cylinders = int.Parse(node["cylinders"].InnerText);


                                // insert into Petrol table in courseowrkdb.db database
                                string temp10 = "INSERT INTO petrol(vehicleID, noise, cylinders) VALUES('" + VehicleID + "', " + Noise + "," + Cylinders + "); ";
                                string r10 = dbAccess.sqlChange(temp10);

                            }
                            else
                            {
                                
                                int Voltage = int.Parse(node["voltage"].InnerText);
                                int Brushed = int.Parse(node["brushed"].InnerText);

                                // insert into Electric table in courseowrkdb.db database
                                string temp11 = "INSERT INTO electric(vehicleID, voltage, brushed) VALUES('" + VehicleID + "', " + Voltage + "," + Brushed + "); ";
                                string r11 = dbAccess.sqlChange(temp11);


                            }

                        } // end of foreach 
                    }// end of if statement of try 

            else
            {
                // A blank value is not valid xml
                // listBox is empty when the Xml file loaded is invalid.
            }
        } // end of try
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            ErrorBox.Text = "Invalid Xml file loaded!\r\n" + ex.Message + " ";
                   

        }
                // finally block runs regardless of how try block ended.
                finally
                {
                   
                    ErrorBox.Text = ErrorBox.Text + " Finished, Want to try again?";
                  
                }




            }
}

private void listBox_SelectedIndexChanged(object sender, EventArgs e)
{
    if (listBox.SelectedIndex != -1)
    {
        propertyGrid.SelectedObject = listBox.SelectedItem;
    }
}

        

//=====================================================================
// Expert User
//=====================================================================
        private void btnQuery_Click(object sender, EventArgs e)
{
            txtResult.Clear();
    string response;
    

    // "StringComparison.OrdinalIgnoreCase"  ignores the case of select in the query.
    if (CustomQueryBox.Text.StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))

    {
        response = dbAccess.sqlQuery(CustomQueryBox.Text);
    }
    else
    {
        response = "Don't change the database" + Environment.NewLine;
        
    }
    txtResult.Text += response;


    //SELECT *FROM vehicle  or select * from vehicle
}

private void txtResult_TextChanged(object sender, EventArgs e)
{
    txtResult.SelectionStart = txtResult.Text.Length;
    txtResult.ScrollToCaret();
}

private void textBox1_TextChanged(object sender, EventArgs e)
{
    //Scrollbar for the error textbox for invalid Xml file.
    ErrorBox.SelectionStart = ErrorBox.Text.Length;
    ErrorBox.ScrollToCaret();
}
//=================================================================
// Begin NOVICE USER 
//=================================================================
private void NoviceUserBox_TextChanged(object sender, EventArgs e)
{
    //NoviceUserBox.SelectionStart = NoviceUserBox.Text.Length;
    //NoviceUserBox.ScrollToCaret();
}


private void rbtnTop5Range_vehicle_CheckedChanged(object sender, EventArgs e)
{
    NoviceUserBox.Clear();
    string temp1 = "SELECT vehicleID, MAX(range) FROM vehicle GROUP BY vehicleID ORDER BY MAX(range) DESC LIMIT 5 ";
    string r1 = dbAccess.sqlQuery(temp1);
    NoviceUserBox.Text = r1;

}

private void rbtnTop5Weight_vehicle_CheckedChanged(object sender, EventArgs e)
{
    NoviceUserBox.Clear();
    string temp2 = "SELECT vehicleID, MAX(Weight) FROM vehicle GROUP BY vehicleID ORDER BY MAX(Weight) DESC LIMIT 5 ";
    string r2 = dbAccess.sqlQuery(temp2);
    NoviceUserBox.Text = r2;
}

private void rbtnTop5CarryCapacity_vehicle_CheckedChanged(object sender, EventArgs e)
{
    NoviceUserBox.Clear();
    string temp3 = "SELECT vehicleID, MAX(carryCapacity) FROM vehicle GROUP BY vehicleID ORDER BY MAX(carryCapacity) DESC LIMIT 5 ";
    string r3 = dbAccess.sqlQuery(temp3);
    NoviceUserBox.Text = r3;
}

private void rbtnTop5Topspeed_vehicle_CheckedChanged(object sender, EventArgs e)
{
    NoviceUserBox.Clear();
    string temp4 = "SELECT vehicleID, MAX(topspeed) FROM vehicle GROUP BY vehicleID ORDER BY MAX(topspeed) DESC LIMIT 5 ";
    string r4 = dbAccess.sqlQuery(temp4);
    NoviceUserBox.Text = r4;
}

private void rbtnTop5Rnage_petrol_CheckedChanged(object sender, EventArgs e)
{
    NoviceUserBox.Clear();
    //The following SQL statement selects all from vehicle table with a engine in lowercase that starts with "P%" for Petrol.
    string temp5 = "SELECT vehicleID, MAX(range)  FROM vehicle WHERE lower(engine) LIKE 'P%' GROUP BY vehicleID ORDER BY MAX(range) DESC LIMIT 5";
    string r5 = dbAccess.sqlQuery(temp5);
    NoviceUserBox.Text = r5;
}

private void rbtnTop5Range_electric_CheckedChanged(object sender, EventArgs e)
{
    NoviceUserBox.Clear();
    //The following SQL statement selects all from vehicle table with a engine in lowercase that starts with "E%" for Electric.
    string temp6 = "SELECT vehicleID, MAX(range) FROM vehicle WHERE lower(engine) LIKE 'E%' GROUP BY vehicleID ORDER BY MAX(range) DESC LIMIT 5 ";
    string r6 = dbAccess.sqlQuery(temp6);
    NoviceUserBox.Text = r6;
}

private void rbtnAvgTopspeed_vehicle_CheckedChanged(object sender, EventArgs e)
{
    NoviceUserBox.Clear();
    string temp7 = "SELECT avg(topspeed) AS 'Average' FROM vehicle";
    string r7 = dbAccess.sqlQuery(temp7);
    NoviceUserBox.Text = r7;
}

private void rbtnAvgtopspeed_petrol_CheckedChanged(object sender, EventArgs e)
{
    NoviceUserBox.Clear();
    string temp7 = "SELECT avg(topspeed) AS 'Average' FROM vehicle WHERE lower(engine) LIKE 'P%'";
    string r7 = dbAccess.sqlQuery(temp7);
    NoviceUserBox.Text = r7;
}

private void rbtnAvgTopspeed_electric_CheckedChanged(object sender, EventArgs e)
{
    NoviceUserBox.Clear();
    string temp7 = "SELECT avg(topspeed) AS 'Average' FROM vehicle WHERE lower(engine) LIKE 'E%'";
    string r7 = dbAccess.sqlQuery(temp7);
    NoviceUserBox.Text = r7;
}

private void rbtnTop5Weight_petrol_CheckedChanged(object sender, EventArgs e)
{
    //The following SQL statement selects all from vehicle table with a engine in lowercase that starts with "P%" for Petrol.
    string temp5 = "SELECT vehicleID, MAX(weight)  FROM vehicle WHERE lower(engine) LIKE 'P%' GROUP BY vehicleID ORDER BY MAX(weight) DESC LIMIT 5";
    string r5 = dbAccess.sqlQuery(temp5);
    NoviceUserBox.Text = r5;
}

private void rbtnTop5CarryCapacity_petrol_CheckedChanged(object sender, EventArgs e)
{
    //The following SQL statement selects all from vehicle table with a engine in lowercase that starts with "P%" for Petrol.
    string temp5 = "SELECT vehicleID, MAX(CarryCapacity)  FROM vehicle WHERE lower(engine) LIKE 'P%' GROUP BY vehicleID ORDER BY MAX(CarryCapacity) DESC LIMIT 5";
    string r5 = dbAccess.sqlQuery(temp5);
    NoviceUserBox.Text = r5;
}

private void rbtnTop5Topspeed_petrol_CheckedChanged(object sender, EventArgs e)
{
    //The following SQL statement selects all from vehicle table with a engine in lowercase that starts with "P%" for Petrol.
    string temp5 = "SELECT vehicleID, MAX(Topspeed)  FROM vehicle WHERE lower(engine) LIKE 'P%' GROUP BY vehicleID ORDER BY MAX(Topspeed) DESC LIMIT 5";
    string r5 = dbAccess.sqlQuery(temp5);
    NoviceUserBox.Text = r5;
}

private void rbtnTop5Weight_Electric_CheckedChanged(object sender, EventArgs e)
{
    NoviceUserBox.Clear();
    //The following SQL statement selects all from vehicle table with a engine in lowercase that starts with "E%" for Electric.
    string temp6 = "SELECT vehicleID, MAX(Weight) FROM vehicle WHERE lower(engine) LIKE 'E%' GROUP BY vehicleID ORDER BY MAX(Weight) DESC LIMIT 5 ";
    string r6 = dbAccess.sqlQuery(temp6);
    NoviceUserBox.Text = r6;
}

private void rbtnTop5CarryCapacity_Electric_CheckedChanged(object sender, EventArgs e)
{

    NoviceUserBox.Clear();
    //The following SQL statement selects all from vehicle table with a engine in lowercase that starts with "E%" for Electric.
    string temp6 = "SELECT vehicleID, MAX(CarryCapacity) FROM vehicle WHERE lower(engine) LIKE 'E%' GROUP BY vehicleID ORDER BY MAX(CarryCapacity) DESC LIMIT 5 ";
    string r6 = dbAccess.sqlQuery(temp6);
    NoviceUserBox.Text = r6;
}

private void rbtnTop5Topspeed_Electric_CheckedChanged(object sender, EventArgs e)
{
    NoviceUserBox.Clear();
    //The following SQL statement selects all from vehicle table with a engine in lowercase that starts with "E%" for Electric.
    string temp6 = "SELECT vehicleID, MAX(Topspeed) FROM vehicle WHERE lower(engine) LIKE 'E%' GROUP BY vehicleID ORDER BY MAX(Topspeed) DESC LIMIT 5 ";
    string r6 = dbAccess.sqlQuery(temp6);
    NoviceUserBox.Text = r6;
}

//=====================================================================
        // ComboBox Begin 
//=====================================================================
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnTimeDurationVehicle.Checked)
            {
                NoviceUserBox.Clear();
                // display the corresponding Range in textBox3 for the selected vehicleId in the comboBox1.
                string temp0 = "SELECT range from Vehicle WHERE (vehicleID = '" + comboBox1.SelectedItem + "'); ";
                string r0 = dbAccess.sqlQuery(temp0);
                textBox3.Text = r0;

                // display the corresponding topspeed in textBox4 for the selected vehicleId in the comboBox1.
                string temp1 = "SELECT topspeed from Vehicle WHERE (vehicleID = '" + comboBox1.SelectedItem + "'); ";
                string r1 = dbAccess.sqlQuery(temp1);
                textBox4.Text = r1;

                // Display the calculated time duration for the chosen vehicle in NoviceUserBox.
                NoviceUserBox.Text = comboBox1.SelectedItem.ToString() + "\t running at top speed could run for " + (double.Parse(textBox3.Text) / float.Parse(textBox4.Text)).ToString() + " seconds.";

                NoviceUserBox.Text += Environment.NewLine + "(Assuming range is constant regardless of any other factor, time duration is calculated using range/topspeed formula)\n";
            }

        }

//=====================================================================
// ComboBox End
//=====================================================================
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnTimeDurationVehicle_CheckedChanged(object sender, EventArgs e)
        {

        }

        //=================================================================
        // END of NOVICE USER 
        //=================================================================

    }
}
