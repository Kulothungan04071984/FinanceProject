namespace Finance
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.KeyDown += Menu_KeyDown;
            this.KeyPreview = true;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            MenuStrip menuStrip1 = new MenuStrip();
            this.Controls.Add(menuStrip1);

            // Create Menu Items
            //ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            //ToolStripMenuItem editMenu = new ToolStripMenuItem("Edit");

            //menuStrip1.Items.Add(fileMenu);
            //menuStrip1.Items.Add(editMenu);

            // Apply custom renderer
            menuStrip1.Renderer = new CustomMenuRenderer();

            // Set custom font
            menuStrip1.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.TopMost = true;



        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ClassStyle |= 0x200; // CS_NOCLOSE
                return cp;
            }
        }

        public class CustomMenuRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (e.Item.Selected)
                {
                    e.Graphics.FillRectangle(Brushes.LightBlue, e.Item.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.Silver, e.Item.Bounds);
                }
            }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                // Do nothing to remove the border
            }
        }

        private void cUSTOMERMASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CUSTOMER TRANSACTION PAGE");
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }
    }
}
