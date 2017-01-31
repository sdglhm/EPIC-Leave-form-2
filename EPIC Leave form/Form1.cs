using EPIC_Leave_form.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPIC_Leave_form
{
    public partial class Form1 : Form
    {
        class leaveInfo
        {
            public String date { get; set; }
            public String name { get; set; }
            public String department { get; set; }
            public String typeofleave { get; set; }
            public String days { get; set; }
            public String from { get; set; }
            public String returnon { get; set; }
            public String emergcontact { get; set; }
            public String subsname { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            this.Dc_print.PrintPage += new System.Drawing.Printing.PrintPageEventHandler (this.printDocument1_PrintPage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            txtdep.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtdep.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.Add("Research & Innovation");
            col.Add("Quality Assurance");
            col.Add("Finance");
            txtdep.AutoCompleteCustomSource = col;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            leaveInfo listofinfo = new leaveInfo();

            listofinfo.name = txtname.Text;
            listofinfo.date = datecurrent.Text;
            listofinfo.emergcontact = txttp.Text;
            listofinfo.department = txtdep.Text;
            listofinfo.subsname = txtsub.Text;
            listofinfo.typeofleave = cmbtype.Text;
            listofinfo.days = txtdays.Text;
            listofinfo.from = datefrom.Text;
            listofinfo.returnon = datereturn.Text;

            string herotext = "EPIC LANKA (PVT.) LTD.";
            string formtxt = "32/FO/AD/10";
            string applicationtite = "APPLICATION FOR LEAVE";


            Font printFont = new Font ("Arial", 16, FontStyle.Regular);
            Font printFont2 = new Font("Arial", 12, FontStyle.Regular);
            Font printFont3 = new Font("Arial", 10, FontStyle.Regular);

            //Printing the background box
            SolidBrush graybrush = new SolidBrush(Color.LightGray);
            Rectangle rect = new Rectangle(10, 10, 810, 70);

            e.Graphics.FillRectangle(graybrush, rect);

            //Printing the logo
            e.Graphics.DrawImage(EPIC_Leave_form.Properties.Resources.logo, 25, 15,80,65);

            //Printing the hero text
            e.Graphics.DrawString(herotext, printFont, Brushes.Black, 120, 35);
            e.Graphics.DrawString(formtxt, printFont, Brushes.Black, 670, 35);

            //Application title
            e.Graphics.DrawString(applicationtite, printFont2, Brushes.Black, 300, 85);

            //Date
            e.Graphics.DrawString("DATE: " + listofinfo.date, printFont2, Brushes.Black, 25, 135);

            e.Graphics.DrawString("NAME OF APPLICANT: " + listofinfo.name, printFont2, Brushes.Black, 25, 170);
            e.Graphics.DrawString("DEPARTMENT: " + listofinfo.department, printFont2, Brushes.Black, 325, 135);
            e.Graphics.DrawString("TYPE OF LEAVE: " + listofinfo.typeofleave, printFont2, Brushes.Black, 25, 205);
            e.Graphics.DrawString("NO. OF DAYS: " + listofinfo.days, printFont2, Brushes.Black, 325,205);

            //Printing table
            Pen blackPen = new Pen(Color.Black,1);
            int x = 50;
            int y = 245;
            int width = 740;
            int height = 25;

            e.Graphics.DrawRectangle(blackPen, x, y, width, height);
            e.Graphics.DrawRectangle(blackPen, x, y+25, width, height);

            for (int i = 0; i < 6; i++)
            {
                e.Graphics.DrawLine(blackPen, x+(740/6*i),y,x+(740 / 6 * i), y+50);

                switch (i)
                {
                    case 0:
                        e.Graphics.DrawString("Casual", printFont2, Brushes.Black, x + (740 / 6 * i)+30, y+25);
                        if (listofinfo.typeofleave == "Casual")
                        {
                            e.Graphics.DrawImage(EPIC_Leave_form.Properties.Resources.tick, x + (740 / 6 * i) + 50, y, 25, 25);
                        }
                        break;
                    case 1:
                        e.Graphics.DrawString("Medical", printFont2, Brushes.Black, x + (740 / 6 * i) + 30, y + 25);
                        if (listofinfo.typeofleave == "Medical")
                        {
                            e.Graphics.DrawImage(EPIC_Leave_form.Properties.Resources.tick, x + (740 / 6 * i) + 50, y, 25, 25);
                        }
                        break;
                    case 2:
                        e.Graphics.DrawString("No Pay", printFont2, Brushes.Black, x + (740 / 6 * i) + 30, y + 25);
                        if (listofinfo.typeofleave == "No pay")
                        {
                            e.Graphics.DrawImage(EPIC_Leave_form.Properties.Resources.tick, x + (740 / 6 * i) + 50, y, 25, 25);
                        }
                        break;
                    case 3:
                        e.Graphics.DrawString("Other", printFont2, Brushes.Black, x + (740 / 6 * i) + 30, y + 25);
                        if (listofinfo.typeofleave == "Other")
                        {
                            e.Graphics.DrawImage(EPIC_Leave_form.Properties.Resources.tick, x + (740 / 6 * i) + 50, y, 25, 25);
                        }
                        break;
                    case 4:
                        e.Graphics.DrawString("Annual", printFont2, Brushes.Black, x + (740 / 6 * i) + 30, y + 25);
                        if (listofinfo.typeofleave == "Annual")
                        {
                            e.Graphics.DrawImage(EPIC_Leave_form.Properties.Resources.tick, x + (740 / 6 * i) + 50, y, 25, 25);
                        }
                        break;
                    case 5:
                        e.Graphics.DrawString("Lieu", printFont2, Brushes.Black, x + (740 / 6 * i) + 30, y + 25);
                        if (listofinfo.typeofleave == "Lieu")
                        {
                            e.Graphics.DrawImage(EPIC_Leave_form.Properties.Resources.tick, x + (740 / 6 * i) + 50, y, 25, 25);
                        }

                        break;

                    default:
                        break;
                }
            }

            //Drawing 2nd rect
            e.Graphics.DrawRectangle(blackPen, x, y+50, width, height+170);

            //Left items
            e.Graphics.DrawString("LEAVE FROM: " + listofinfo.from, printFont3, Brushes.Black, x+10, y+55);
            e.Graphics.DrawString("EMERGENCY CONTACT NUMBER: " + listofinfo.emergcontact, printFont3, Brushes.Black, x + 10, y + 80);
            e.Graphics.DrawString("SIGNATURE OF APPLICANT: __________________", printFont3, Brushes.Black, x + 10, y + 105);
            e.Graphics.DrawString("SUBSTITUTES NAME: " + listofinfo.subsname, printFont3, Brushes.Black, x + 10, y + 130);
            e.Graphics.DrawString("CHECKED BY: ________________________", printFont3, Brushes.Black, x + 10, y + 155);
            e.Graphics.DrawString("IF NOT APPROVED REASON IN BRIEF:  ________________________________________", printFont3, Brushes.Black, x + 10, y + 185);
            e.Graphics.DrawString("                                                                  ________________________________________", printFont3, Brushes.Black, x + 10, y + 205);

            //Right items
            e.Graphics.DrawString("RETURN ON:: " + listofinfo.returnon, printFont3, Brushes.Black, x + 350, y + 55);
            e.Graphics.DrawString("SIGNATURE: __________________" + listofinfo.subsname, printFont3, Brushes.Black, x + 450, y + 130);
            e.Graphics.DrawString("APPROVED BY: ________________________", printFont3, Brushes.Black, x + 350, y + 155);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //printDocument1.DefaultPageSettings.Landscape=true;

            
            printPreviewDialog1.Document = Dc_print;
            printPreviewDialog1.Document.DefaultPageSettings.Landscape = false;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A5", 580, 830);
            //printPreviewDialog1.Document.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A5", 580, 830);
            printPreviewDialog1.ShowDialog();
        }
    }
}
