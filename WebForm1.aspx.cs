using System;
using System.Web.UI;

namespace WebApplication1
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve numbers from textboxes
                int num1 = int.Parse(TextBox1.Text);
                int num2 = int.Parse(TextBox2.Text);

                // Calculate the sum
                int sum = num1 + num2;

                // Display the result
                ResultLabel.Text = "Sum: " + sum;
            }
            catch (FormatException)
            {
                ResultLabel.Text = "Error: Please enter valid numbers.";
            }
        }
    }
}
