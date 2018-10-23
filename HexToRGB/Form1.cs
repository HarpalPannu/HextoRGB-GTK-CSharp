using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HexToRGB{
    public partial class Form1 : Form{
        public Form1() {
            InitializeComponent();
            hexcode.BorderStyle = BorderStyle.FixedSingle;
        }

        private void showToolTip()
        {
            ToolTip tt = new ToolTip();
            tt.Show("Invalid Color Code", hexcode, 0, 0, 2100);
        }

        private void button1_Click(object sender, EventArgs e){

            Regex pattern = new Regex(@"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$");
            string hexColorCode = hexcode.Text.Trim();
            if(hexColorCode == "")
            {
                showToolTip();
                return;
            }
            if(hexColorCode.Substring(0, 1) != "#"){
                hexColorCode = "#" + hexColorCode;
            }
            Match validColor = pattern.Match(hexColorCode);
            if (validColor.Success)  {
                rValue.Text = "Yes";
                color.BackColor = System.Drawing.ColorTranslator.FromHtml(hexColorCode);
                string rHex = "0x" + hexColorCode.Substring(1, 2);
                string gHex = "0x" + hexColorCode.Substring(3, 2);
                string bHex = "0x" + hexColorCode.Substring(5, 2);
                rValue.Text = Convert.ToInt32(rHex, 16).ToString();
                gValue.Text = Convert.ToInt32(gHex, 16).ToString();
                bValue.Text = Convert.ToInt32(bHex, 16).ToString();
            }
            else {
                showToolTip();
            }

        }
    }
}
