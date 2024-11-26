namespace IFSPStore.App.Cadastros
{
    partial class CadastroCidade
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
            txtNomeCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPage1.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cboEstado);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(txtNomeCidade);
            tabPage1.Controls.SetChildIndex(txtNomeCidade, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(cboEstado, 0);
            // 
            // txtNomeCidade
            // 
            txtNomeCidade.AnimateReadOnly = false;
            txtNomeCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeCidade.BackgroundImageLayout = ImageLayout.None;
            txtNomeCidade.CharacterCasing = CharacterCasing.Normal;
            txtNomeCidade.Depth = 0;
            txtNomeCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeCidade.HideSelection = true;
            txtNomeCidade.Hint = "Informe o nome da cidade";
            txtNomeCidade.LeadingIcon = null;
            txtNomeCidade.Location = new Point(243, 19);
            txtNomeCidade.MaxLength = 32767;
            txtNomeCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeCidade.Name = "txtNomeCidade";
            txtNomeCidade.PasswordChar = '\0';
            txtNomeCidade.PrefixSuffixText = null;
            txtNomeCidade.ReadOnly = false;
            txtNomeCidade.RightToLeft = RightToLeft.No;
            txtNomeCidade.SelectedText = "";
            txtNomeCidade.SelectionLength = 0;
            txtNomeCidade.SelectionStart = 0;
            txtNomeCidade.ShortcutsEnabled = true;
            txtNomeCidade.Size = new Size(250, 48);
            txtNomeCidade.TabIndex = 2;
            txtNomeCidade.TabStop = false;
            txtNomeCidade.TextAlign = HorizontalAlignment.Left;
            txtNomeCidade.TrailingIcon = null;
            txtNomeCidade.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(6, 19);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(231, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "Estado";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "SP", "AM", "PI", "MG", "RO", "MG", "DT" });
            cboEstado.Location = new Point(509, 19);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 5;
            // 
            // CadastroCidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroCidade";
            Text = "Cadastro de Cidades";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
    }
}