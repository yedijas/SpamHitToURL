using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpamHitToURL.Models;

namespace SpamHitToURL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAERBrowse_Click(object sender, EventArgs e)
        {
            if (ofdMain.ShowDialog() == DialogResult.OK)
            {
                tbSampleAER.Text = ofdMain.FileName;
            }
        }

        private void btnCTBrowse_Click(object sender, EventArgs e)
        {
            if (ofdMain.ShowDialog() == DialogResult.OK)
            {
                tbSampleCT.Text = ofdMain.FileName;
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Console.WriteLine(DateTime.Now);
                int TotalThreads = int.Parse(tbNoOfThreads.Text);
                int TotalDuration = int.Parse(tbDuration.Text);
                DateTime startTime = DateTime.Now;
                var tasks = new List<Task>();
                int counter = 0;

                for (int i = 0; i < TotalDuration; i++)
                {
                    // populating tasks
                    for (int j = 0; j < TotalThreads; j++)
                    {
                        // both xml helpers are initiated here to allow the consistent ID
                        counter += 1;
                        XMLProcessorHelper myAERHelper = new XMLProcessorHelper(j + (50 * i), tbSampleCT.Text, true);
                        XMLProcessorHelper myCTHelper = new XMLProcessorHelper(j + (50 * i), tbSampleCT.Text, false);
                        tasks.Add(Task.Run(
                            () =>
                            {
                                MyPersonalAction(myAERHelper, myCTHelper);
                            }
                            ));
                    }

                    // init tasks
                    Task t = Task.WhenAll(tasks.ToArray());
                    try
                    {
                        //Task.WaitAll(tasks.ToArray());
                        t.Wait();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    tasks.Clear();
                    Thread.Sleep(1000); // 1 second delay to the next iteration
                }
                DateTime EndTime = DateTime.Now;

                MessageBox.Show("The simulation start \nfrom: " + startTime + " and ended \non: " + EndTime + ".\nIt had posted " + counter + " transactions");
            }
            else
            {
                return;
            }
        }

        private void MyPersonalAction(XMLProcessorHelper myAERHelper, XMLProcessorHelper myCTHelper)
        {
            myAERHelper.ReplaceAllParamsInXML();
            myCTHelper.ReplaceAllParamsInXML();

            //var FinInstnId = myAERHelper.XMLDoc.Element("BusMsg").Descendants("BizMsgIdr").Single();
            //var CdtrAgt = myAERHelper.XMLDoc.Element("BusMsg").Descendants("CdtrAgt").Single().Descendants("FinInstnId").Single().Descendants("Id").Single();

            //Console.WriteLine(FinInstnId.Value);
            //Console.WriteLine(CdtrAgt.Value);
            URIHitterHelper myURIHelper = new URIHitterHelper(tbURL.Text);

            myURIHelper.URI = tbURL.Text;
            myURIHelper.HitUrl(myAERHelper.XMLDoc.ToString());
            myURIHelper.HitUrl(myCTHelper.XMLDoc.ToString());
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(tbNoOfThreads.Text.Trim()) ||
                string.IsNullOrEmpty(tbSampleAER.Text.Trim()) ||
                string.IsNullOrEmpty(tbSampleCT.Text.Trim()) ||
                string.IsNullOrEmpty(tbURL.Text.Trim()))
            {
                MessageBox.Show("Please recheck your input fields!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
