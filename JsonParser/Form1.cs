using Newtonsoft.Json;

namespace JsonParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI events

        private void btnDeserialise_Click(object sender, EventArgs e)
        {
            //debugOutput(txtInput.Text);
            deserealiseJSon(txtInput.Text);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = string.Empty;
        }

        #endregion

        #region json functions

        private void deserealiseJSon(string strJSON)
        {
            try
            {
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonSimple>(strJSON);
                //debugOutput("Here's the name: " + jPerson.name.ToString());

                var jPerson = JsonConvert.DeserializeObject<jsonPersonComplex>(strJSON);
                debugOutput("Here's the name: " + jPerson.name.ToString());
                debugOutput("Here's the city: " + jPerson.address.city);

                //var jPersonDinamic = JsonConvert.DeserializeObject<dynamic>(strJSON);
                //debugOutput("Here's our JSON object: " + jPerson.ToString());
                //debugOutput("Here's the first name: " + jPerson.name);

                var jsonPersonArray = JsonConvert.DeserializeObject<jsonPersonArray>(strJSON);

                foreach (var item in jsonPersonArray.phoneNumbers)
                {
                    debugOutput(item.type.ToString() + " " + item.number.ToString());
                }

            }
            catch (Exception ex)
            {

                debugOutput("We had a problem: " + ex.Message.ToString());
            }

        }


        #endregion

        #region Debug Output

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtDebugOutput.Text = txtDebugOutput.Text + strDebugText + Environment.NewLine;
                txtDebugOutput.SelectionStart = txtDebugOutput.TextLength;
                txtDebugOutput.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }

        #endregion



    }
}