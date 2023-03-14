using OpenAI_API;
using System.Threading.Tasks;

namespace window_form;

public partial class Form1 : Form
{
    private System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();

    public Form1()
    {
        InitializeComponent();
        this.CenterToScreen(); // Center the form on the screen
        AddButton(); // Call the AddButton method
    }

    private void AddButton()
    {
        button1.Text = "Click me!";
        button1.Size = new System.Drawing.Size(100, 50);
        button1.Location = new System.Drawing.Point(
            (this.ClientSize.Width - button1.Width) / 2,
            (this.ClientSize.Height - button1.Height) / 2
        );
        this.Controls.Add(button1);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Label label = new Label();
        label.Text = "Kocham Ilonke i inne czokodylki rubadylki";
        label.AutoSize = true;
        label.Location = new Point(button1.Location.X, button1.Location.Y + button1.Height + 10);
        this.Controls.Add(label);
    }
}
