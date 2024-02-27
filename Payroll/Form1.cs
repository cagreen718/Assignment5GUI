namespace Payroll
{
    public partial class Form1 : Form
    {
        // Constants
        private const decimal cdecFica = 0.0765m;
        private const decimal cdecFed = 0.22m;
        private const decimal cdecState = 0.04m;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Exit button
        {
            //most effecient way to close program Ref:
            //https://stackoverflow.com/questions/9586664/using-exit-button-to-close-a-winform-program
            this.Close();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            //Clear each text box
            //https://stackoverflow.com/questions/16236392/how-to-clear-a-textbox-once-a-button-is-clicked-in-wpf
            textBox1.Text = string.Empty;
            FICAtext.Text = string.Empty;
            Fedtext.Text = string.Empty;
            Statetext.Text = string.Empty;
            NetPaytext.Text = string.Empty;
        }

        private void Compbtn_Click(object sender, EventArgs e)
        {
            // Input Validation
            if (!decimal.TryParse(textBox1.Text, out decimal decIncome))
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
                return;
            }

            // Calculate Taxes
            //https://stackoverflow.com/questions/33266373/i-want-make-math-operation-with-one-button-c-sharp
            decimal decFica = decIncome * cdecFica;
            decimal decFederal = decIncome * cdecFed;
            decimal decState = decIncome * cdecState;
            decimal decNet = decIncome - decFica - decFederal - decState;

            // Display Results
            //https://stackoverflow.com/questions/6543861/displaying-a-result-in-a-textbox-on-a-button-click-asp-net
            FICAtext.Text = decFica.ToString("C2");
            Fedtext.Text = decFederal.ToString("C2");
            Statetext.Text = decState.ToString("C2");
            NetPaytext.Text = decNet.ToString("C2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // net button
        {

        }

        private void FICAtext_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Fedtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Statetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void NetPaytext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
