using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WinFormsLibrary1 {

    public class LabelTextBox : Panel {

        private Label label;
        private MaskedTextBox textBox;
        //private Masks maskSelected = Masks.NONE;

        #region :: CONSTRUCTORS ::
        public LabelTextBox() {
            Initialize("Label 1", string.Empty);
        }

        public LabelTextBox(string labelValue) {
            Initialize(labelValue, string.Empty);
        }

        public LabelTextBox(string labelValue, string textBoxValue) {
            Initialize(labelValue, textBoxValue);
        }
        #endregion

        private void Initialize(string labelValue, string textBoxValue) {
            label = new Label();
            textBox = new MaskedTextBox();

            label.Text = labelValue;
            textBox.Text = textBoxValue;

            this.label.Margin = new Padding(0);
            this.label.Location = new Point(0, ((20/2)-(13/2)));
            this.label.Size = new Size(40, 13);

            this.textBox.Margin = new Padding(0);
            this.textBox.Location = new Point(40, 1);
            this.textBox.Size = new Size(110, 20);

            this.Size = new Size(150, 22);

            this.Controls.Add(label);
            this.Controls.Add(textBox);

            this.SizeChanged += new System.EventHandler(this.panel_SizeChanged);
        }

        [DefaultValue("")]
        [Category("WSCustom")]
        [Browsable(true)]
        [Description("Define o texto associado ao rótulo")]
        public string SetLabelValue {
            get {
                return label.Text;
            }
            set {
                label.Text = value;
                AjustarComponentesFilhos();
            }
        }

        [DefaultValue("")]
        [Category("WSCustom")]
        [Browsable(true)]
        [Description("Define o valor associado ao textBox")]
        public string SetTextBoxValue {
            get {
                return textBox.Text;
            }
            set {
                textBox.Text = value;
            }
        }

        [Category("WSCustom")]
        [Browsable(true)]
        [Description("Define a dimensão do rótulo")]
        public Size SetLabelSize {
            get { return label.Size; }
            set { label.Size = value; }
        }

        [Category("WSCustom")]
        [Browsable(true)]
        [Description("Define a dimensão da caixa de texto")]
        public Size SetTextBoxSize {
            get { return textBox.Size; }
            set { textBox.Size = value; }
        }

        [Category("WSCustom")]
        [Browsable(true)]
        [Description("Define a localização do rótulo")]
        public Point SetLabelLocation {
            get { return label.Location; }
            set { label.Location = value; }
        }

        [Category("WSCustom")]
        [Browsable(true)]
        [Description("Define a localização da caixa de texto")]
        public Point SetTextBoxLocation {
            get { return textBox.Location; }
            set { textBox.Location = value; }
        }

        [Category("WSCustom")]
        [Browsable(true)]
        [Description("Define a margem do rótulo")]
        public Padding SetLabelMargin {
            get { return label.Margin; }
            set { label.Margin = value; }
        }

        [Category("WSCustom")]
        [Browsable(true)]
        [Description("Define a margem da caixa de texto")]
        public Padding SetTextBoxMargin {
            get { return textBox.Margin; }
            set { textBox.Margin = value; }
        }

        /*
        [DefaultValue(maskSelected)]
        [Category("Appearance")]
        [Browsable(true)]
        [Description("Define uma máscara associado ao textBox")]
        public Masks SetMask {
            get {
                return maskSelected;
            }
            set {
                maskSelected = value;
            }
        }
        */

        private void panel_SizeChanged(object sender, EventArgs e) {
            int width = this.Size.Width - label.Size.Width;
            textBox.Size = new Size(width, textBox.Size.Height);
        }

        private void AjustarComponentesFilhos() {
            int width = CalcularComprimentoString(label.Text);
            label.Size = new Size(width, label.Size.Height);

            textBox.Location = new Point(width, textBox.Location.Y);

            int widthTextBox = this.Size.Width - textBox.Location.X;
            textBox.Size = new Size(widthTextBox, textBox.Size.Height);
        }

        private int CalcularComprimentoString(string text) {
            return TextRenderer.MeasureText(text, label.Font).Width;
        }
    }
}