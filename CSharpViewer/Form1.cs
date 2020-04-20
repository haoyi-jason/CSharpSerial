using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CSharpViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable tb1 = new DataTable("table1");
            tb1.Columns.Add(new DataColumn("CH Name"));
            tb1.Columns.Add("Value",System.Type.GetType("System.Double"));
            tb1.Columns.Add(new DataColumn("Unit"));
            //tb1.Columns.Add("COL",)
            tb1.Columns.Add("Enable",System.Type.GetType("System.Boolean"));

            tb1.Rows.Add(new object[] { "Acceleration X", 0.0, "m/s^2", false });
            tb1.Rows.Add(new object[] { "Acceleration Y", 0.0, "m/s^2", false });
            tb1.Rows.Add(new object[] { "Acceleration Z", 0.0, "m/s^2", false });
            tb1.Rows.Add(new object[] { "roll 角加速度(MTI)", 0.0, "deg/s^2", false });
            tb1.Rows.Add(new object[] { "yaw 角加速度(MTI)", 0.0, "deg/s^2", false });
            tb1.Rows.Add(new object[] { "pitch 角加速度(MTI)", 0.0, "deg/s^2", false });

            //DataRow r = tb1.NewRow();
            //r[0] = "CH";
            //r[1] = "value";
            //r[2] = "unit";
            //r[3] = false;
            //tb1.Rows.Add(r);

            //object[] rows =
            //{
            //    new object[]{"CH2","VAL2","UNIT3",false},
            //    new object[]{"CH4","VAL4","UNIT4",false},
            //};

            dataGridView1.DataSource = tb1;

            cbPort.Items.AddRange(SerialPort.GetPortNames());

        }

    }
}
