
namespace WindowsFormsApp1
{
    partial class RegistForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonregister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutClickButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passRegistFieldReturn = new System.Windows.Forms.TextBox();
            this.passRegistField = new System.Windows.Forms.TextBox();
            this.loginRegistField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonregister
            // 
            this.buttonregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonregister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonregister.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonregister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonregister.Location = new System.Drawing.Point(59, 360);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(255, 45);
            this.buttonregister.TabIndex = 6;
            this.buttonregister.Text = "Зарегестрироваться";
            this.buttonregister.UseVisualStyleBackColor = true;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.OutClickButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 66);
            this.panel1.TabIndex = 2;
            // 
            // OutClickButton
            // 
            this.OutClickButton.AutoSize = true;
            this.OutClickButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutClickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutClickButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OutClickButton.Location = new System.Drawing.Point(329, 3);
            this.OutClickButton.Name = "OutClickButton";
            this.OutClickButton.Size = new System.Drawing.Size(30, 29);
            this.OutClickButton.TabIndex = 1;
            this.OutClickButton.Text = "X";
            this.OutClickButton.Click += new System.EventHandler(this.OutClickButton_Click);
            this.OutClickButton.MouseEnter += new System.EventHandler(this.OutClickButton_MouseEnter_1);
            this.OutClickButton.MouseLeave += new System.EventHandler(this.OutClickButton_MouseLeave_1);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.passRegistFieldReturn);
            this.panel2.Controls.Add(this.buttonregister);
            this.panel2.Controls.Add(this.passRegistField);
            this.panel2.Controls.Add(this.loginRegistField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 435);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // passRegistFieldReturn
            // 
            this.passRegistFieldReturn.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passRegistFieldReturn.Location = new System.Drawing.Point(33, 273);
            this.passRegistFieldReturn.Name = "passRegistFieldReturn";
            this.passRegistFieldReturn.Size = new System.Drawing.Size(300, 45);
            this.passRegistFieldReturn.TabIndex = 7;
            this.passRegistFieldReturn.UseSystemPasswordChar = true;
            this.passRegistFieldReturn.Enter += new System.EventHandler(this.passRegistFieldReturn_Enter);
            this.passRegistFieldReturn.Leave += new System.EventHandler(this.passRegistFieldReturn_Leave);
            // 
            // passRegistField
            // 
            this.passRegistField.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passRegistField.Location = new System.Drawing.Point(33, 207);
            this.passRegistField.Name = "passRegistField";
            this.passRegistField.Size = new System.Drawing.Size(300, 45);
            this.passRegistField.TabIndex = 5;
            this.passRegistField.UseSystemPasswordChar = true;
            this.passRegistField.Enter += new System.EventHandler(this.passRegistField_Enter);
            this.passRegistField.Leave += new System.EventHandler(this.passRegistField_Leave);
            // 
            // loginRegistField
            // 
            this.loginRegistField.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegistField.Location = new System.Drawing.Point(33, 97);
            this.loginRegistField.Multiline = true;
            this.loginRegistField.Name = "loginRegistField";
            this.loginRegistField.Size = new System.Drawing.Size(300, 63);
            this.loginRegistField.TabIndex = 2;
            this.loginRegistField.Enter += new System.EventHandler(this.loginRegistField_Enter);
            this.loginRegistField.Leave += new System.EventHandler(this.loginRegistField_Leave);
            // 
            // RegistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(368, 435);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(368, 435);
            this.Name = "RegistForm";
            this.Text = "RegistForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OutClickButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passRegistField;
        private System.Windows.Forms.TextBox loginRegistField;
        private System.Windows.Forms.TextBox passRegistFieldReturn;
    }
}