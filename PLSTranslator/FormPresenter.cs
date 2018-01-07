using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PLSTranslator
{
    class FormPresenter
    {
        public FormPresenter(IForm form)
        {
            Form = form;
            Form.LoadEvent += LoadFile;
            Form.Save += SaveFile;
        }

        private IForm Form { get; set; }

        public void LoadFile(object sender, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                var dx = new XmlSerializer(typeof(Xliff));
                var cc = (Xliff)dx.Deserialize(fs);
                Form.Xliff = cc;
            }
        }

        public void SaveFile(object sender, Xliff xliff)
        {
            var sd = new SaveFileDialog();
            if (sd.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(sd.FileName))
                {
                    var dx = new XmlSerializer(typeof(Xliff));
                    dx.Serialize(writer, xliff);
                    writer.Close();
                }
            }
        }
    }
}
