using System.Data.OleDb;
using System.Runtime.CompilerServices;

namespace A01_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        bool isNewEntry = false;
        private int originalWidth;
        double firstNumber = 0;
        string operation = "";

        string dbPath = @"C:\LOCALDB\Calculator.mdb";



        private void InsertEquationToDatabase(string equationText)
        {
            string connStr = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source ={dbPath};";
            string insertQuery = "INSERT INTO tbl_Calculator_History (Equation) Values (@equation)";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();
                    OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@equation", equationText);
                    insertCmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert error: " + ex.Message);
                }
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.Width = 220;

            originalWidth = this.Width;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (this.Width >= 370)
            {
                this.Width = originalWidth;
            }
            else
            {
                this.Width = 370;
            }
        }




        private void Load_Key(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (isNewEntry)
            {
                txtDisplay.Text = "";
                isNewEntry = false;
            }

            if (txtDisplay.Text == "0" && btn.Text != ".")
            {
                txtDisplay.Text = "";
            }

            int dotCount = txtDisplay.Text.Count(c => c == '.');
            if (dotCount >= 1)
            {
                if (btn.Text != ".")
                {
                    txtDisplay.Text += btn.Text;
                    txtEquation.Text = btn.Text;
                }
            }
            else if (txtDisplay.Text == "" && btn.Text == ".")
            {
                txtDisplay.Text += "0.";
                txtEquation.Text += "0.";
            }
            else
            {
                txtDisplay.Text += btn.Text;
                if (txtDisplay.Text.Contains(".."))
                {
                    txtDisplay.Text = txtDisplay.Text.Replace("..", ".");
                }
                txtEquation.Text += btn.Text;
            }
        }

        private void Operator(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (double.TryParse(txtEquation.Text, out firstNumber))
            {
                operation = btn.Text;
                isNewEntry = true;

                txtEquation.Text = firstNumber.ToString() + " " + operation + " ";
            }

        }

        private void Total()
        {
            double secondNumber;

            double result = 0;

            if (!double.TryParse(txtDisplay.Text, out secondNumber))
                return;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }

            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("Cannot divide by zero");
                    return;
                }
                result = firstNumber / secondNumber;
            } 
            txtDisplay.Text = result.ToString();
            txtEquation.Text += "=" + result.ToString();

            

            isNewEntry = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Total();
        }
    }
}