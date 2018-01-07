using System;
using System.Windows.Forms;

namespace PLSTranslator
{
    public partial class Form1 : Form, IForm
    {
        private Xliff _xliff;
        private FormPresenter fp;

        public Form1()
        {
            InitializeComponent();
            fp = new FormPresenter(this);
        }

        private IForm Form { get; set; }

        public event EventHandler<Xliff> Save;
        public event EventHandler<string> LoadEvent;

        public Xliff Xliff
        {
            get => _xliff;
            set
            {
                _xliff = value;
                transunitBindingSource.DataSource = value.File.Body.Transunit;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var openFileDialog = new OpenFileDialog { Multiselect = false };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
                LoadEvent?.Invoke(this, openFileDialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save(this, Xliff);
        }
    }

    internal interface IForm
    {
        event EventHandler<Xliff> Save;
        event EventHandler<string> LoadEvent;
        Xliff Xliff { get; set; }
    }
}
