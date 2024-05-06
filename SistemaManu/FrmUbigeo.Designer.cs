namespace SistemaManu
{
    partial class FrmUbigeo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUbigeo));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dgvUbigeo = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbigeo)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltitulo
            // 
            this.labeltitulo.Location = new System.Drawing.Point(-2206, 9);
            this.labeltitulo.Size = new System.Drawing.Size(0, 24);
            this.labeltitulo.Text = "";
            // 
            // dgvUbigeo
            // 
            this.dgvUbigeo.AllowUserToAddRows = false;
            this.dgvUbigeo.AllowUserToDeleteRows = false;
            this.dgvUbigeo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUbigeo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUbigeo.Location = new System.Drawing.Point(27, 100);
            this.dgvUbigeo.Name = "dgvUbigeo";
            this.dgvUbigeo.ReadOnly = true;
            this.dgvUbigeo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUbigeo.Size = new System.Drawing.Size(366, 210);
            this.dgvUbigeo.TabIndex = 5;
            //this.dgvUbigeo.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUbigeo_CellEnter);
            this.dgvUbigeo.DoubleClick += new System.EventHandler(this.dgvUbigeo_DoubleClick);
            //this.dgvUbigeo.Enter += new System.EventHandler(this.dgvUbigeo_Enter);
            // 
            // txtbuscar
            // 
            this.txtbuscar.AcceptsReturn = false;
            this.txtbuscar.AcceptsTab = false;
            this.txtbuscar.AnimationSpeed = 200;
            this.txtbuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbuscar.BackgroundImage")));
            this.txtbuscar.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtbuscar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtbuscar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtbuscar.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtbuscar.BorderRadius = 1;
            this.txtbuscar.BorderThickness = 1;
            this.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.DefaultText = "";
            this.txtbuscar.FillColor = System.Drawing.Color.White;
            this.txtbuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtbuscar.HideSelection = true;
            this.txtbuscar.IconLeft = null;
            this.txtbuscar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.IconPadding = 10;
            this.txtbuscar.IconRight = null;
            this.txtbuscar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.Lines = new string[0];
            this.txtbuscar.Location = new System.Drawing.Point(27, 47);
            this.txtbuscar.MaxLength = 32767;
            this.txtbuscar.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbuscar.Modified = false;
            this.txtbuscar.Multiline = false;
            this.txtbuscar.Name = "txtbuscar";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtbuscar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtbuscar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtbuscar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.Highlight;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtbuscar.OnIdleState = stateProperties4;
            this.txtbuscar.Padding = new System.Windows.Forms.Padding(3);
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtbuscar.PlaceholderText = "BUSCAR POR DISTRITO";
            this.txtbuscar.ReadOnly = false;
            this.txtbuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.SelectionLength = 0;
            this.txtbuscar.SelectionStart = 0;
            this.txtbuscar.ShortcutsEnabled = true;
            this.txtbuscar.Size = new System.Drawing.Size(260, 38);
            this.txtbuscar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbuscar.TextMarginBottom = 0;
            this.txtbuscar.TextMarginLeft = 3;
            this.txtbuscar.TextMarginTop = 0;
            this.txtbuscar.TextPlaceholder = "BUSCAR POR DISTRITO";
            this.txtbuscar.UseSystemPasswordChar = false;
            this.txtbuscar.WordWrap = true;
            // 
            // FrmUbigeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 339);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dgvUbigeo);
            this.Name = "FrmUbigeo";
            this.Text = "FrmUbigeo";
            this.Load += new System.EventHandler(this.FrmUbigeo_Load);
            this.Controls.SetChildIndex(this.dgvUbigeo, 0);
            this.Controls.SetChildIndex(this.txtbuscar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbigeo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUbigeo;
        private Bunifu.UI.WinForms.BunifuTextBox txtbuscar;
    }
}