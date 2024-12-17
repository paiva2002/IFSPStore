namespace IFSPStore.App.Cadastros
{
    partial class CadastroProduto
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUnidadeVenda = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboGrupo = new ReaLTaiizor.Controls.MaterialComboBox();
            txtPreco = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDataCompra = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabPage1.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtDataCompra);
            tabPage1.Controls.Add(txtPreco);
            tabPage1.Controls.Add(cboGrupo);
            tabPage1.Controls.Add(txtUnidadeVenda);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.SetChildIndex(txtNome, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(txtUnidadeVenda, 0);
            tabPage1.Controls.SetChildIndex(cboGrupo, 0);
            tabPage1.Controls.SetChildIndex(txtPreco, 0);
            tabPage1.Controls.SetChildIndex(txtDataCompra, 0);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 6);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(593, 48);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(632, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(119, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.AnimateReadOnly = false;
            txtUnidadeVenda.AutoCompleteMode = AutoCompleteMode.None;
            txtUnidadeVenda.AutoCompleteSource = AutoCompleteSource.None;
            txtUnidadeVenda.BackgroundImageLayout = ImageLayout.None;
            txtUnidadeVenda.CharacterCasing = CharacterCasing.Normal;
            txtUnidadeVenda.Depth = 0;
            txtUnidadeVenda.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUnidadeVenda.HideSelection = true;
            txtUnidadeVenda.Hint = "Unidade Venda";
            txtUnidadeVenda.LeadingIcon = null;
            txtUnidadeVenda.Location = new Point(6, 114);
            txtUnidadeVenda.MaxLength = 32767;
            txtUnidadeVenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.PasswordChar = '\0';
            txtUnidadeVenda.PrefixSuffixText = null;
            txtUnidadeVenda.ReadOnly = false;
            txtUnidadeVenda.RightToLeft = RightToLeft.No;
            txtUnidadeVenda.SelectedText = "";
            txtUnidadeVenda.SelectionLength = 0;
            txtUnidadeVenda.SelectionStart = 0;
            txtUnidadeVenda.ShortcutsEnabled = true;
            txtUnidadeVenda.Size = new Size(250, 48);
            txtUnidadeVenda.TabIndex = 5;
            txtUnidadeVenda.TabStop = false;
            txtUnidadeVenda.TextAlign = HorizontalAlignment.Left;
            txtUnidadeVenda.TrailingIcon = null;
            txtUnidadeVenda.UseSystemPasswordChar = false;
            // 
            // cboGrupo
            // 
            cboGrupo.AutoResize = false;
            cboGrupo.BackColor = Color.FromArgb(255, 255, 255);
            cboGrupo.Depth = 0;
            cboGrupo.DrawMode = DrawMode.OwnerDrawVariable;
            cboGrupo.DropDownHeight = 174;
            cboGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrupo.DropDownWidth = 121;
            cboGrupo.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboGrupo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboGrupo.FormattingEnabled = true;
            cboGrupo.Hint = "Grupo";
            cboGrupo.IntegralHeight = false;
            cboGrupo.ItemHeight = 43;
            cboGrupo.Location = new Point(262, 59);
            cboGrupo.MaxDropDownItems = 4;
            cboGrupo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboGrupo.Name = "cboGrupo";
            cboGrupo.Size = new Size(323, 49);
            cboGrupo.StartIndex = 0;
            cboGrupo.TabIndex = 7;
            // 
            // txtPreco
            // 
            txtPreco.AllowPromptAsInput = true;
            txtPreco.AnimateReadOnly = false;
            txtPreco.AsciiOnly = false;
            txtPreco.BackgroundImageLayout = ImageLayout.None;
            txtPreco.BeepOnError = false;
            txtPreco.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.HidePromptOnLeave = false;
            txtPreco.HideSelection = true;
            txtPreco.Hint = "Preço";
            txtPreco.InsertKeyMode = InsertKeyMode.Default;
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(6, 59);
            txtPreco.Mask = "999.999,99";
            txtPreco.MaxLength = 32767;
            txtPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPreco.Name = "txtPreco";
            txtPreco.PasswordChar = '\0';
            txtPreco.PrefixSuffixText = null;
            txtPreco.PromptChar = '_';
            txtPreco.ReadOnly = false;
            txtPreco.RejectInputOnFirstFailure = false;
            txtPreco.ResetOnPrompt = true;
            txtPreco.ResetOnSpace = true;
            txtPreco.RightToLeft = RightToLeft.No;
            txtPreco.SelectedText = "";
            txtPreco.SelectionLength = 0;
            txtPreco.SelectionStart = 0;
            txtPreco.ShortcutsEnabled = true;
            txtPreco.Size = new Size(250, 48);
            txtPreco.SkipLiterals = true;
            txtPreco.TabIndex = 8;
            txtPreco.TabStop = false;
            txtPreco.Text = "   ,   .";
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            txtPreco.ValidatingType = null;
            // 
            // txtDataCompra
            // 
            txtDataCompra.AllowPromptAsInput = true;
            txtDataCompra.AnimateReadOnly = false;
            txtDataCompra.AsciiOnly = false;
            txtDataCompra.BackgroundImageLayout = ImageLayout.None;
            txtDataCompra.BeepOnError = false;
            txtDataCompra.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataCompra.Depth = 0;
            txtDataCompra.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataCompra.HidePromptOnLeave = false;
            txtDataCompra.HideSelection = true;
            txtDataCompra.Hint = "Data da Compra";
            txtDataCompra.InsertKeyMode = InsertKeyMode.Default;
            txtDataCompra.LeadingIcon = null;
            txtDataCompra.Location = new Point(6, 168);
            txtDataCompra.Mask = "99/99/9999";
            txtDataCompra.MaxLength = 32767;
            txtDataCompra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataCompra.Name = "txtDataCompra";
            txtDataCompra.PasswordChar = '\0';
            txtDataCompra.PrefixSuffixText = null;
            txtDataCompra.PromptChar = '_';
            txtDataCompra.ReadOnly = false;
            txtDataCompra.RejectInputOnFirstFailure = false;
            txtDataCompra.ResetOnPrompt = true;
            txtDataCompra.ResetOnSpace = true;
            txtDataCompra.RightToLeft = RightToLeft.No;
            txtDataCompra.SelectedText = "";
            txtDataCompra.SelectionLength = 0;
            txtDataCompra.SelectionStart = 0;
            txtDataCompra.ShortcutsEnabled = true;
            txtDataCompra.Size = new Size(250, 48);
            txtDataCompra.SkipLiterals = true;
            txtDataCompra.TabIndex = 9;
            txtDataCompra.TabStop = false;
            txtDataCompra.Text = "  /  /";
            txtDataCompra.TextAlign = HorizontalAlignment.Left;
            txtDataCompra.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataCompra.TrailingIcon = null;
            txtDataCompra.UseSystemPasswordChar = false;
            txtDataCompra.ValidatingType = null;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroProduto";
            Text = "CadastroProduto";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboGrupo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUnidadeVenda;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPreco;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataCompra;
    }
}