namespace CaesarEncryption
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblInput = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblReverseInput = new System.Windows.Forms.Label();
            this.tbxReverseInput = new System.Windows.Forms.TextBox();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caesarString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reverseCaesarString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(12, 9);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(98, 14);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input string:";
            // 
            // tbxInput
            // 
            this.tbxInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.Location = new System.Drawing.Point(113, 6);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(213, 22);
            this.tbxInput.TabIndex = 1;
            this.tbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(12, 36);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(105, 14);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output string:";
            // 
            // dgvOutput
            // 
            this.dgvOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.caesarString,
            this.reverseCaesarString});
            this.dgvOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgvOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOutput.Location = new System.Drawing.Point(113, 33);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.Size = new System.Drawing.Size(681, 363);
            this.dgvOutput.TabIndex = 6;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(344, 4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "PROCESS";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblReverseInput
            // 
            this.lblReverseInput.AutoSize = true;
            this.lblReverseInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReverseInput.Location = new System.Drawing.Point(425, 9);
            this.lblReverseInput.Name = "lblReverseInput";
            this.lblReverseInput.Size = new System.Drawing.Size(154, 14);
            this.lblReverseInput.TabIndex = 3;
            this.lblReverseInput.Text = "Reverse Input string:";
            // 
            // tbxReverseInput
            // 
            this.tbxReverseInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReverseInput.Location = new System.Drawing.Point(581, 6);
            this.tbxReverseInput.Name = "tbxReverseInput";
            this.tbxReverseInput.Size = new System.Drawing.Size(213, 22);
            this.tbxReverseInput.TabIndex = 4;
            this.tbxReverseInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            // 
            // index
            // 
            this.index.HeaderText = "Key";
            this.index.Name = "index";
            this.index.Width = 40;
            // 
            // caesarString
            // 
            this.caesarString.HeaderText = "Caesar String";
            this.caesarString.Name = "caesarString";
            this.caesarString.Width = 200;
            // 
            // reverseCaesarString
            // 
            this.reverseCaesarString.HeaderText = "Reverse Caesar String";
            this.reverseCaesarString.Name = "reverseCaesarString";
            this.reverseCaesarString.Width = 200;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 408);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.tbxReverseInput);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lblReverseInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Caesar Encryption";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn caesarString;
        private System.Windows.Forms.DataGridViewTextBoxColumn reverseCaesarString;
        private System.Windows.Forms.Label lblReverseInput;
        private System.Windows.Forms.TextBox tbxReverseInput;
    }
}

