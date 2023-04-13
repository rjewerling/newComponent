using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsLibrary1 {

    public enum Masks {
        FONE,
        CEP,
        RG,
        CPF,
        PIS,
        EMAIL,
        MONETARY,
        NONE
    }

    public class LabelTextBox : Panel {

        private Label label;
        private MaskedTextBox textBox;

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

            this.SuspendLayout();

            this.label.AutoSize = true;
            this.label.Location = new Point(1, 1);
            this.label.Name = "label1";
            this.label.Size = new Size(35, 13);
            this.label.TabIndex = 0;
            this.label.Text = "label1";
            
            this.textBox.Location = new Point(40, 1);
            this.textBox.Name = "textBox1";
            this.textBox.Size = new Size(100, 20);
            this.textBox.TabIndex = 1;

            this.Controls.Add(label);
            this.Controls.Add(textBox);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        [DefaultValue("Label1")]
        [Category("Appearance")]
        [Browsable(true)]
        [Description("Define o texto associado ao rótulo")]
        public string SetLabelValue {
            get {
                return label.Text;
            }
            set {
                label.Text = value;
            }
        }

        [DefaultValue("")]
        [Category("Appearance")]
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

        [DefaultValue(Masks.NONE)]
        [Category("Appearance")]
        [Browsable(true)]
        [Description("Define uma máscara associado ao textBox")]
        public int SetMask(Masks mask) {
            textBox.Mask = mask;
        } 
    }
}